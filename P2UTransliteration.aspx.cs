using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class P2UTransliteration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnTransliterate_Click(object sender, EventArgs e)
    {
        string PunjabiData = txtPunjabi.Text;
        string UrduData = null, check = null;
        int len = PunjabiData.Length;
        char check1 = '\0';
        for (int i = 0; i < len; i++)
        {
            char tempChar = PunjabiData[i];
            if (tempChar == '।')
            {
                UrduData += '۔';
            }
            if (tempChar == '.')
            {
                UrduData += '۔';
            }
            if (tempChar == '.')
            {
                UrduData += '۔';
            }
            if (tempChar == '’')
            {
                UrduData += '\'';
            }
            if (tempChar == '‘')
            {
                UrduData += '\'';
            }
            if (tempChar == ';')
            {
                UrduData += '؛';
            }
            if (tempChar == '?')
            {
                UrduData += '؟';
            }
            if (tempChar == '>' || tempChar == '<' || tempChar == '_' || tempChar == '\n' || tempChar == '%' || tempChar == '@' || tempChar == '~' || tempChar == '!' || tempChar == '#' || tempChar == '$' || tempChar == '^' || tempChar == '&' || tempChar == ' ' || tempChar == '-' || tempChar == ',' || tempChar == '\"' || tempChar == '\'' || tempChar == ':')
            {
                UrduData += tempChar;
            }
            if (tempChar == ')' || tempChar == '(' || tempChar == '+' || tempChar == '`' || tempChar == '|' || tempChar == '\\' || tempChar == '/' || tempChar == '=')
            {
                UrduData += tempChar;
            }
            if (tempChar == '੧')
            {
                UrduData += '۱';
            }
            if (tempChar == '੨')
            {
                UrduData += '۲';
            }
            if (tempChar == '੩')
            {
                UrduData += '۳';
            }
            if (tempChar == '੪')
            {
                UrduData += '۴';
            }
            if (tempChar == '੫')
            {
                UrduData += '۵';
            }
            if (tempChar == '੬')
            {
                UrduData += '۶';
            }
            if (tempChar == '੭')
            {
                UrduData += '۷';
            }
            if (tempChar == '੮')
            {
                UrduData += '۸';
            }
            if (tempChar == '੯')
            {
                UrduData += '۹';
            }
            if (tempChar == '੦')
            {
                UrduData += '۰';
            }
            if (tempChar == '1')
            {
                UrduData += '۱';
            }
            if (tempChar == '2')
            {
                UrduData += '۲';
            }
            if (tempChar == '3')
            {
                UrduData += '۳';
            }
            if (tempChar == '4')
            {
                UrduData += '۴';
            }
            if (tempChar == '5')
            {
                UrduData += '۵';
            }
            if (tempChar == '6')
            {
                UrduData += '۶';
            }
            if (tempChar == '7')
            {
                UrduData += '۷';
            }
            if (tempChar == '8')
            {
                UrduData += '۸';
            }
            if (tempChar == '9')
            {
                UrduData += '۹';
            }
            if (tempChar == '0')
            {
                UrduData += '۰';
            }
            if (tempChar == 'ੋ' || tempChar == 'ੌ')
            {
                UrduData += 'و';
            }
            if (tempChar == 'ਾ')
            {
                UrduData += 'ا';
            }
            if (tempChar == 'ੀ' || tempChar == 'ੇ' || tempChar == 'ੈ')
            {
                UrduData += 'ی';
            }
            if (tempChar == '੍')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "੍ਹ")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "੍ਹਾ")
                            {
                                if (i + 3 < len)
                                {
                                    check += PunjabiData[i + 3];
                                    if (check == "੍ਹਾਂ")
                                    {
                                        UrduData += "ہاں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "ہا";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "ہا";
                                    i += 2;
                                }
                            }
                            else if (check == "੍ਹੋ")
                            {
                                UrduData += "ہو";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ہ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ہ";
                            i++;
                        }
                    }
                }
            }
            if (tempChar == 'ਓ')
            {
                if (i - 1 >= 0)
                {
                    check1 = PunjabiData[i - 1];
                    if (check1 == 'ਅ' || check1 == 'ਆ' || check1 == 'ਈ' || check1 == 'ਇ' || check1 == 'ਏ' || check1 == 'ਐ' || check1 == 'ਔ' || check1 == 'ਾ' || check1 == 'ੀ' || check1 == 'ਿ' || check1 == 'ੇ' || check1 == 'ੋ' || check1 == 'ੌ' || check1 == 'ੈ')
                    {
                        UrduData += "و";
                    }
                    else
                    {
                        UrduData += "او";
                    }
                }
                else
                {
                    UrduData += "او";
                }
            }
            if (tempChar == 'ਉ' || tempChar == 'ੳ')
            {
                if (i - 1 >= 0)
                {
                    check1 = PunjabiData[i - 1];
                    if (check1 == 'ਿ')
                    {
                        UrduData += "یو";
                    }
                    else if (check1 == 'ਅ' || check1 == 'ਆ' || check1 == 'ਈ' || check1 == 'ਇ' || check1 == 'ਏ' || check1 == 'ਐ' || check1 == 'ਾ' || check1 == 'ੀ' || check1 == 'ੇ' || check1 == 'ੋ' || check1 == 'ੌ' || check1 == 'ੈ')
                    {
                        check += tempChar;
                        if (i + 1 < len)
                        {
                            check += PunjabiData[i + 1];
                            if (check == "ਉਂ")
                            {
                                UrduData += "وں";
                                i++;
                            }
                            else
                            {
                                UrduData += "و";
                            }
                        }
                        else
                        {
                            UrduData += "و";
                        }
                    }
                    else
                    {
                        check += tempChar;
                        if (i + 1 < len)
                        {
                            check += PunjabiData[i + 1];
                            if (check == "ਉਂ")
                            {
                                UrduData += "اں";
                                i++;
                            }
                            else
                            {
                                UrduData += "ا";
                            }
                        }
                        else
                        {
                            UrduData += "ا";
                        }
                    }
                }
                else
                {
                    check += tempChar;
                    if (i + 1 < len)
                    {
                        check += PunjabiData[i + 1];
                        if (check == "ਉਂ")
                        {
                            UrduData += "اں";
                            i++;
                        }
                        else
                        {
                            UrduData += "ا";
                        }
                    }
                    else
                    {
                        UrduData += "ا";
                    }
                }
            }
            if(tempChar == 'ਊ')
            {
                if (i - 1 >= 0)
                {
                    check1 = PunjabiData[i - 1];
                    if (check1 == 'ਿ')
                    {
                        UrduData += "یو";
                    }
                    else if (check1 == 'ਅ' || check1 == 'ਆ' || check1 == 'ਈ' || check1 == 'ਇ' || check1 == 'ਏ' || check1 == 'ਐ' || check1 == 'ਔ' || check1 == 'ਾ' || check1 == 'ੀ' || check1 == 'ੇ' || check1 == 'ੋ' || check1 == 'ੌ' || check1 == 'ੈ')
                    {
                        check += tempChar;
                        if (i + 1 < len)
                        {
                            check += PunjabiData[i + 1];
                            if (check == "ਊਂ")
                            {
                                UrduData += "وں";
                                i++;
                            }
                            else
                            {
                                UrduData += "و";
                            }
                        }
                        else
                        {
                            UrduData += "و";
                        }
                    }
                    else
                    {
                        check += tempChar;
                        if (i + 1 < len)
                        {
                            check += PunjabiData[i + 1];
                            if (check == "ਊਂ")
                            {
                                UrduData += "اوں";
                                i++;
                            }
                            else
                            {
                                UrduData += "او";
                            }
                        }
                        else
                        {
                            UrduData += "او";
                        }
                    }
                }
                else
                {
                    check += tempChar;
                    if (i + 1 < len)
                    {
                        check += PunjabiData[i + 1];
                        if (check == "ਊਂ")
                        {
                            UrduData += "اوں";
                            i++;
                        }
                        else
                        {
                            UrduData += "او";
                        }
                    }
                    else
                    {
                        UrduData += "او";
                    }
                }
            }
            if(tempChar == 'ਅ')
            {
                if (i - 1 >= 0)
                {
                    check1 = PunjabiData[i - 1];
                    if (check1 == 'ਾ' || check1 == 'ੀ' || check1 == 'ਿ' || check1 == 'ੇ' || check1 == 'ੋ' || check1 == 'ੌ' || check1 == 'ੈ')
                    {
                        UrduData += "ئ";
                    }
                    else if (check1 == 'ਓ' || check1 == 'ੳ' || check1 == 'ਉ' || check1 == 'ਊ' || check1 == 'ਈ' || check1 == 'ਇ' || check1 == 'ਏ')
                    {
                        check += tempChar;
                        if (i + 1 < len)
                        {
                            check += PunjabiData[i + 1];
                            if (check == "ਅੰ")
                            {
                                UrduData += "ن";
                            }
                            else
                            {
                                UrduData += "";
                            }
                        }
                        else
                        {
                            UrduData += 'ا';
                        }
                    }
                    else
                    {
                        check += tempChar;
                        if (i + 1 < len)
                        {
                            check += PunjabiData[i + 1];
                            if (check == "ਅੰ")
                            {
                                UrduData += "ان";
                            }
                            else
                            {
                                UrduData += 'ا';
                            }
                        }
                        else
                        {
                            UrduData += 'ا';
                        }
                    }
                }
                else
                {
                    check += tempChar;
                    if (i + 1 < len)
                    {
                        check += PunjabiData[i + 1];
                        if (check == "ਅੰ")
                        {
                            UrduData += "ان";
                        }
                        else
                        {
                            UrduData += 'ا';
                        }
                    }
                    else
                    {
                        UrduData += 'ا';
                    }
                }
            }
            if(tempChar == 'ਔ')
            {
                if (i - 1 >= 0)
                {
                    check1 = PunjabiData[i - 1];
                    if (check1 == 'ਓ' || check1 == 'ੳ' || check1 == 'ਉ' || check1 == 'ਊ' || check1 == 'ਈ' || check1 == 'ਇ' || check1 == 'ਏ' || check1 == 'ਾ' || check1 == 'ੀ' || check1 == 'ਿ' || check1 == 'ੇ' || check1 == 'ੋ' || check1 == 'ੌ' || check1 == 'ੈ')
                    {                       
                        UrduData += 'و';                       
                    }
                    else
                    {
                        UrduData += "او";
                    }
                }
                else
                {
                    UrduData += "او"; 
                }                
            }
            if(tempChar == 'ਐ')
            {
                if (i + 1 < len)
                {
                    check1 = PunjabiData[i + 1];
                    if (check1 == 'ਂ')
                    {
                        UrduData += "ایں";
                        i++;
                    }
                    else
                    {
                        UrduData += "ای";
                    }
                }
                else
                {
                    UrduData += "ای";
                }
            }
            if(tempChar == 'ਆ')
            {
                if (i - 1 >= 0)
                {
                    check1 = PunjabiData[i - 1];
                    if(check1 == 'ਿ')
                    {
                        if (i + 1 < len)
                        {
                            check1 = PunjabiData[i + 1];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "یاں";
                                i++;
                            }
                            else
                            {
                                UrduData += "یا";
                            }
                        }
                        else
                        {
                            UrduData += "یا";
                        } 
                    }
                    else if (check1 == 'ੀ' || check1 == 'ਈ')
                    {
                        if (i + 1 < len)
                        {
                            check1 = PunjabiData[i + 1];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "اں";
                                i++;
                            }
                            else
                            {
                                UrduData += 'ا';
                            }
                        }
                        else
                        {
                            UrduData += 'ا';
                        }
                    }
                    else
                    {
                        if (i + 1 < len)
                        {
                            check1 = PunjabiData[i + 1];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "آں";
                                i++;
                            }
                            else
                            {
                                UrduData += 'آ';
                            }
                        }
                        else
                        {
                            UrduData += 'آ';
                        }
                    }
                }
                else
                {
                    if (i + 1 < len)
                    {
                        check1 = PunjabiData[i + 1];
                        if (check1 == 'ਂ')
                        {
                            UrduData += "آں";
                            i++;
                        }
                        else
                        {
                            UrduData += 'آ';
                        }
                    }
                    else
                    {
                        UrduData += 'آ';
                    }
                }
            }
            if(tempChar == 'ਏ')
            {
                UrduData += "ئے"; 
            }
            if(tempChar == 'ਈ')
            {
                if (i - 1 >= 0)
                {
                    check1 = PunjabiData[i - 1];
                    if (check1 == 'ਆ' || check1 == 'ਾ' || check1 == 'ੀ' || check1 == 'ਿ' || check1 == 'ੇ' || check1 == 'ੋ' || check1 == 'ੌ' || check1 == 'ੈ')
                    {
                        UrduData += "ئی";
                    }
                    else
                    {
                        UrduData += "ای";
                    }
                }
                else
                {
                    UrduData += "ای";
                }
            }
            if(tempChar == 'ਇ')
            {
                if (i - 1 >= 0)
                {
                    check1 = PunjabiData[i - 1];
                    if (check1 == 'ਆ' || check1 == 'ਾ' || check1 == 'ੀ' || check1 == 'ਿ' || check1 == 'ੇ' || check1 == 'ੋ' || check1 == 'ੌ' || check1 == 'ੈ')
                    {
                        if (i + 1 < len)
                        {
                            check1 = PunjabiData[i + 1];
                            if (check1 == 'ਆ')
                            {
                                UrduData += "یا";
                                i++;
                            }
                            else
                            {
                                UrduData += "ئ";
                            }
                        }
                        else
                        {
                            UrduData += "ئ";
                        }
                    }
                    else
                    {
                        if (i + 1 < len)
                        {
                            check1 = PunjabiData[i + 1];
                            if (check1 == 'ਆ')
                            {
                                UrduData += "یا";
                                i++;
                            }
                            else
                            {
                                UrduData += 'ا';
                            }
                        }
                        else
                        {
                            UrduData += "ا";
                        }
                    }
                }
                else
                {
                    if (i + 1 < len)
                    {
                        check1 = PunjabiData[i + 1];
                        if (check1 == 'ਆ')
                        {
                            UrduData += "یا";
                            i++;
                        }
                        else
                        {
                            UrduData += 'ا';
                        }
                    }
                    else
                    {
                        UrduData += "ا";
                    }
                }  
            }
            if(tempChar == 'ੲ')
            {
                UrduData += 'ع'; 
            }
            if (tempChar == 'ਹ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਹਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ہاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ہا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ہا";
                            i++;
                        }
                    }
                    else if (check == "ਹੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ہوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ہو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ہو";
                            i++;
                        }
                    }
                    else if (check == "ਹੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ہیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ہی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ہی";
                            i++;
                        }
                    }
                    else if (check == "ਹਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "ہں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ہ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ہ";
                            i++;
                        }
                    }
                    else if (check == "ਹੁ")
                    {
                        UrduData += "ہ";
                        i++;
                    }
                    else if (check == "ਹੂ")
                    {
                        UrduData += "ہو";
                        i++;
                    }
                    else if (check == "ਹੌ")
                    {
                        UrduData += "ہو";
                        i++;
                    }
                    else if (check == "ਹੇ")
                    {
                        UrduData += "ہے";
                        i++;
                    }
                    else if (check == "ਹੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ہیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ہے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ہے";
                            i++;
                        }
                    }
                    else if (check == "ਹੰ")
                    {
                        UrduData += "ہں";
                        i++;
                    }
                    else if (check == "ਹਂ")
                    {
                        UrduData += "ہں";
                        i++;
                    }
                    else if (check == "ਹੱ")
                    {
                        UrduData += "ہ";
                        i++;
                    }
                    else
                    {
                        UrduData += 'ہ';
                    }
                }
                else
                {
                    UrduData += 'ہ';
                }
            }
            if (tempChar == 'ਕ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਕਈ")
                    {
                        UrduData += "کئی";
                        i++;
                    }
                    else if (check == "ਕਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "کاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "کا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "کا";
                            i++;
                        }
                    }
                    else if (check == "ਕੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "کوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "کو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "کو";
                            i++;
                        }
                    }
                    else if (check == "ਕੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "کیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "کی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "کی";
                            i++;
                        }
                    }
                    else if (check == "ਕਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "کں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ک";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ک";
                            i++;
                        }
                    }
                    else if (check == "ਕੁ")
                    {
                        UrduData += "ک";
                        i++;
                    }
                    else if (check == "ਕੂ")
                    {
                        UrduData += "کو";
                        i++;
                    }
                    else if (check == "ਕੌ")
                    {
                        UrduData += "کو";
                        i++;
                    }
                    else if (check == "ਕੇ")
                    {
                        UrduData += "کے";
                        i++;
                    }
                    else if (check == "ਕੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "کیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "کی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "کی";
                            i++;
                        }
                    }
                    else if (check == "ਕੰ")
                    {
                        UrduData += "کم";
                        i++;
                    }
                    else if (check == "ਕਂ")
                    {
                        UrduData += "کن";
                        i++;
                    }
                    else if (check == "ਕੱ")
                    {
                        UrduData += "ک";
                        i++;
                    }
                    else if (check == "ਕ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਕ੍ਰ")
                            {
                                UrduData += "کر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += 'ک';
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'ک';
                            i++;
                        }
                    }
                    else
                        UrduData += 'ک';
                }
                else
                    UrduData += 'ک';
            }
            if (tempChar == 'ਖ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਖਈ")
                    {
                        UrduData += "کھئی";
                        i++;
                    }
                    else if (check == "ਖ਼")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਖ਼ਾ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "خاں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "خا";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "خا";
                                    i += 2;
                                }
                            }
                            else if (check == "ਖ਼ੀ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "خیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "خی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "خی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਖ਼ਿ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "خں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "خ";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "خ";
                                    i += 2;
                                }
                            }
                            else if (check == "ਖ਼ੋ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "خون";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "خو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "خو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਖ਼ੌ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "خوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "خو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "خو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਖ਼ੈ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "خیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "خی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "خی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਖ਼ੇ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "خےں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "خے";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "خے";
                                    i += 2;
                                }
                            }
                            else if (check == "ਖ਼ੁ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "خں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "خ";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "خ";
                                    i += 2;
                                }
                            }
                            else if (check == "ਖ਼ੂ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "خوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "خو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "خو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਖ਼ੰ")
                            {
                                UrduData += "خں";
                                i += 2;
                            }
                            else if (check == "ਖ਼ਂ")
                            {
                                UrduData += "خن";
                                i += 2;
                            }
                            else if (check == "ਖ਼ੱ")
                            {
                                UrduData += "خ";
                                i += 2;
                            }
                            else if (check == "ਖ਼੍")
                            {
                                if (i + 3 < len)
                                {
                                    check += PunjabiData[i + 3];
                                    if (check == "ਖ਼੍ਰ")
                                    {
                                        UrduData += "خر";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += 'خ';
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += 'خ';
                                    i += 2;
                                }
                            }
                            else
                            {
                                UrduData += 'خ';
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'خ';
                            i++;
                        }
                    }
                    else if (check == "ਖਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "کھاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "کھا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "کھا";
                            i++;
                        }
                    }
                    else if (check == "ਖੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "کھوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "کھو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "کھو";
                            i++;
                        }
                    }
                    else if (check == "ਖੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "کھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "کھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "کھی";
                            i++;
                        }
                    }
                    else if (check == "ਖਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "کھں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "کھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "کھ";
                            i++;
                        }
                    }
                    else if (check == "ਖੁ")
                    {
                        UrduData += "کھ";
                        i++;
                    }
                    else if (check == "ਖੂ")
                    {
                        UrduData += "کھو";
                        i++;
                    }
                    else if (check == "ਖੌ")
                    {
                        UrduData += "کھو";
                        i++;
                    }
                    else if (check == "ਖੇ")
                    {
                        UrduData += "کھے";
                        i++;
                    }
                    else if (check == "ਖੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "کھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "کھے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "کھے";
                            i++;
                        }
                    }
                    else if (check == "ਖੰ")
                    {
                        UrduData += "کھم";
                        i++;
                    }
                    else if (check == "ਖਂ")
                    {
                        UrduData += "کھن";
                        i++;
                    }
                    else if (check == "ਖੱ")
                    {
                        UrduData += "کھ";
                        i++;
                    }
                    else if (check == "ਖ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਖ੍ਰ")
                            {
                                UrduData += "کھر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "کھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "کھ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ک';
                        UrduData += 'ھ';
                    }
                }
                else
                {
                    UrduData += 'ک';
                    UrduData += 'ھ';
                }
            }
            if (tempChar == 'ਗ') 
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਗਈ")
                    {
                        UrduData += "گئی";
                        i++;
                    }
                    else if (check == "ਗ਼")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਗ਼ਾ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "غاں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "غا";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "غا";
                                    i += 2;
                                }
                            }
                            else if (check == "ਗ਼ੀ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "غیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "غی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "غی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਗ਼ਿ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "غں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "غ";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "غ";
                                    i += 2;
                                }
                            }
                            else if (check == "ਗ਼ੋ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "غون";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "غو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "غو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਗ਼ੌ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "غوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "غو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "غو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਗ਼ੈ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "غیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "غی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "غی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਗ਼ੇ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "غےں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "غے";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "غے";
                                    i += 2;
                                }
                            }
                            else if (check == "ਗ਼ੁ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "غں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "غ";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "غ";
                                    i += 2;
                                }
                            }
                            else if (check == "ਗ਼ੂ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "غوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "غو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "غو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਗ਼ੰ")
                            {
                                UrduData += "غں";
                                i += 2;
                            }
                            else if (check == "ਗ਼ਂ")
                            {
                                UrduData += "غن";
                                i += 2;
                            }
                            else if (check == "ਗ਼ੱ")
                            {
                                UrduData += "غ";
                                i += 2;
                            }
                            else if (check == "ਗ਼੍")
                            {
                                if (i + 3 < len)
                                {
                                    check += PunjabiData[i + 3];
                                    if (check == "ਗ਼੍ਰ")
                                    {
                                        UrduData += "غر";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += 'غ';
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += 'غ';
                                    i += 2;
                                }
                            }
                            else
                            {
                                UrduData += 'غ';
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'غ';
                            i++;
                        }
                    }
                    else if (check == "ਗਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "گاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گا";
                            i++;
                        }
                    }
                    else if (check == "ਗੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "گوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گو";
                            i++;
                        }
                    }
                    else if (check == "ਗੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "گیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گی";
                            i++;
                        }
                    }
                    else if (check == "ਗਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "گں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گ";
                            i++;
                        }
                    }
                    else if (check == "ਗੁ")
                    {
                        UrduData += "گ";
                        i++;
                    }
                    else if (check == "ਗੂ")
                    {
                        UrduData += "گو";
                        i++;
                    }
                    else if (check == "ਗੌ")
                    {
                        UrduData += "گو";
                        i++;
                    }
                    else if (check == "ਗੇ")
                    {
                        UrduData += "گے";
                        i++;
                    }
                    else if (check == "ਗੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "گیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گے";
                            i++;
                        }
                    }
                    else if (check == "ਗੰ")
                    {
                        UrduData += "گم";
                        i++;
                    }
                    else if (check == "ਗਂ")
                    {
                        UrduData += "گن";
                        i++;
                    }
                    else if (check == "ਗੱ")
                    {
                        UrduData += "گ";
                        i++;
                    }
                    else if (check == "ਗ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਗ੍ਰ")
                            {
                                UrduData += "گر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'گ';
                    }
                }
                else
                {
                    UrduData += 'گ';
                }
            }
            if (tempChar == 'ਘ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਘਈ")
                    {
                        UrduData += "گھئی";
                        i++;
                    }
                    else if (check == "ਘਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "گھاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گھا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گھا";
                            i++;
                        }
                    }
                    else if (check == "ਘੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "گھوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گھو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گھو";
                            i++;
                        }
                    }
                    else if (check == "ਘੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "گھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گھی";
                            i++;
                        }
                    }
                    else if (check == "ਘਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "گھں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گھ";
                            i++;
                        }
                    }
                    else if (check == "ਘੁ")
                    {
                        UrduData += "گھ";
                        i++;
                    }
                    else if (check == "ਘੂ")
                    {
                        UrduData += "گھو";
                        i++;
                    }
                    else if (check == "ਘੌ")
                    {
                        UrduData += "گھو";
                        i++;
                    }
                    else if (check == "ਘੇ")
                    {
                        UrduData += "گھے";
                        i++;
                    }
                    else if (check == "ਘੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "گھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "گھے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "گھے";
                            i++;
                        }
                    }
                    else if (check == "ਘੰ")
                    {
                        UrduData += "گھم";
                        i++;
                    }
                    else if (check == "ਘਂ")
                    {
                        UrduData += "گھن";
                        i++;
                    }
                    else if (check == "ਘੱ")
                    {
                        UrduData += "گھ";
                        i++;
                    }
                    else if (check == "ਘ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਘ੍ਰ")
                            {
                                UrduData += "گھر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += 'گ';
                                UrduData += 'ھ';
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'گ';
                            UrduData += 'ھ';
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'گ';
                        UrduData += 'ھ';
                    }
                }
                else
                {
                    UrduData += 'گ';
                    UrduData += 'ھ';
                }
            }
            if (tempChar == 'ਚ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਚਈ")
                    {
                        UrduData += "چئی";
                        i++;
                    }
                    else if (check == "ਚਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "چاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چا";
                            i++;
                        }
                    }
                    else if (check == "ਚੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "چوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چو";
                            i++;
                        }
                    }
                    else if (check == "ਚੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "چیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چی";
                            i++;
                        }
                    }
                    else if (check == "ਚਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "چں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چ";
                            i++;
                        }
                    }
                    else if (check == "ਚੁ")
                    {
                        UrduData += "چ";
                        i++;
                    }
                    else if (check == "ਚੂ")
                    {
                        UrduData += "چو";
                        i++;
                    }
                    else if (check == "ਚੌ")
                    {
                        UrduData += "چو";
                        i++;
                    }
                    else if (check == "ਚੇ")
                    {
                        UrduData += "چے";
                        i++;
                    }
                    else if (check == "ਚੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "چیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چے";
                            i++;
                        }
                    }
                    else if (check == "ਚੰ")
                    {
                        UrduData += "چم";
                        i++;
                    }
                    else if (check == "ਚਂ")
                    {
                        UrduData += "چن";
                        i++;
                    }
                    else if (check == "ਚੱ")
                    {
                        UrduData += "چ";
                        i++;
                    }
                    else if (check == "ਚ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਚ੍ਰ")
                            {
                                UrduData += "چر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += 'چ';
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'چ';
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'چ';
                    }
                }
                else
                {
                    UrduData += 'چ';
                }
            }
            if (tempChar == 'ਛ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਛਈ")
                    {
                        UrduData += "چھئی";
                        i++;
                    }
                    else if (check == "ਛਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "چھاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چھا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چھا";
                            i++;
                        }
                    }
                    else if (check == "ਛੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "چھوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چھو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چھو";
                            i++;
                        }
                    }
                    else if (check == "ਛੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "چھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چھی";
                            i++;
                        }
                    }
                    else if (check == "ਛਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "چھں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چھ";
                            i++;
                        }
                    }
                    else if (check == "ਛੁ")
                    {
                        UrduData += "چھ";
                        i++;
                    }
                    else if (check == "ਛੂ")
                    {
                        UrduData += "چھو";
                        i++;
                    }
                    else if (check == "ਛੌ")
                    {
                        UrduData += "چھو";
                        i++;
                    }
                    else if (check == "ਛੇ")
                    {
                        UrduData += "چھے";
                        i++;
                    }
                    else if (check == "ਛੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "چھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چھے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چھے";
                            i++;
                        }
                    }
                    else if (check == "ਛੰ")
                    {
                        UrduData += "چھم";
                        i++;
                    }
                    else if (check == "ਛਂ")
                    {
                        UrduData += "چھن";
                        i++;
                    }
                    else if (check == "ਛੱ")
                    {
                        UrduData += "چھ";
                        i++;
                    }
                    else if (check == "ਛ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਛ੍ਰ")
                            {
                                UrduData += "چھر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "چھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "چھ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'چ';
                        UrduData += 'ھ';
                    }
                }
                else
                {
                    UrduData += 'چ';
                    UrduData += 'ھ';
                }
            }
            if (tempChar == 'ਜ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਜਈ")
                    {
                        UrduData += "جئی";
                        i++;
                    }
                    else if (check == "ਜ਼")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਜ਼ਾ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "زاں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "زا";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "زا";
                                    i += 2;
                                }
                            }
                            else if (check == "ਜ਼ੀ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "زیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "زی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "زی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਜ਼ਿ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "زں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "ز";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "ز";
                                    i += 2;
                                }
                            }
                            else if (check == "ਜ਼ੋ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "زون";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "زو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "زو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਜ਼ੌ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "زوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "زو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "زو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਜ਼ੈ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "زیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "زی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "زی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਜ਼ੇ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "زےں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "زے";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "زے";
                                    i += 2;
                                }
                            }
                            else if (check == "ਜ਼ੁ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "زں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "ز";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "ز";
                                    i += 2;
                                }
                            }
                            else if (check == "ਜ਼ੂ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "زوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "زو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "زو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਜ਼ੰ")
                            {
                                UrduData += "زں";
                                i += 2;
                            }
                            else if (check == "ਜ਼ਂ")
                            {
                                UrduData += "زن";
                                i += 2;
                            }
                            else if (check == "ਜ਼ੱ")
                            {
                                UrduData += "ز";
                                i += 2;
                            }
                            else if (check == "ਜ਼੍")
                            {
                                if (i + 3 < len)
                                {
                                    check += PunjabiData[i + 3];
                                    if (check == "ਜ਼੍ਰ")
                                    {
                                        UrduData += "زر";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += 'ز';
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += 'ز';
                                    i += 2;
                                }
                            }
                            else
                            {
                                UrduData += 'ز';
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'ز';
                            i++;
                        }
                    }
                    else if (check == "ਜਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "جاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "جا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "جا";
                            i++;
                        }
                    }
                    else if (check == "ਜੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "جوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "جو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "جو";
                            i++;
                        }
                    }
                    else if (check == "ਜੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "جیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "جی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "جی";
                            i++;
                        }
                    }
                    else if (check == "ਜਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "جں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ج";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ج";
                            i++;
                        }
                    }
                    else if (check == "ਜੁ")
                    {
                        UrduData += "ج";
                        i++;
                    }
                    else if (check == "ਜੂ")
                    {
                        UrduData += "جو";
                        i++;
                    }
                    else if (check == "ਜੌ")
                    {
                        UrduData += "جو";
                        i++;
                    }
                    else if (check == "ਜੇ")
                    {
                        UrduData += "جے";
                        i++;
                    }
                    else if (check == "ਜੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "جیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "جے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "جے";
                            i++;
                        }
                    }
                    else if (check == "ਜੰ")
                    {
                        UrduData += "جن";
                        i++;
                    }
                    else if (check == "ਜਂ")
                    {
                        UrduData += "جن";
                        i++;
                    }
                    else if (check == "ਜੱ")
                    {
                        UrduData += "ج";
                        i++;
                    }
                    else if (check == "ਜ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਜ੍ਰ")
                            {
                                UrduData += "جر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ج";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ج";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ج';
                    }
                }
                else
                {
                    UrduData += 'ج';
                }
            }
            if (tempChar == 'ਝ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਝਈ")
                    {
                        UrduData += "جھئی";
                        i++;
                    }
                    else if (check == "ਝਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "جھاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "جھا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "جھا";
                            i++;
                        }
                    }
                    else if (check == "ਝੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "جھوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "جھو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "جھو";
                            i++;
                        }
                    }
                    else if (check == "ਝੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "جھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "جھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "جھی";
                            i++;
                        }
                    }
                    else if (check == "ਝਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "جھں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "جھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "جھ";
                            i++;
                        }
                    }
                    else if (check == "ਝੁ")
                    {
                        UrduData += "جھ";
                        i++;
                    }
                    else if (check == "ਝੂ")
                    {
                        UrduData += "جھو";
                        i++;
                    }
                    else if (check == "ਝੌ")
                    {
                        UrduData += "جھو";
                        i++;
                    }
                    else if (check == "ਝੇ")
                    {
                        UrduData += "جھے";
                        i++;
                    }
                    else if (check == "ਝੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "جھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "جھے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "جھے";
                            i++;
                        }
                    }
                    else if (check == "ਝੰ")
                    {
                        UrduData += "جھن";
                        i++;
                    }
                    else if (check == "ਝਂ")
                    {
                        UrduData += "جھن";
                        i++;
                    }
                    else if (check == "ਝੱ")
                    {
                        UrduData += "جھ";
                        i++;
                    }
                    else if (check == "ਝ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਝ੍ਰ")
                            {
                                UrduData += "جھر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "جھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "جھ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ج';
                        UrduData += 'ھ';
                    }
                }
                else
                {
                    UrduData += 'ج';
                    UrduData += 'ھ';
                }
            }
            if (tempChar == 'ਟ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਟਈ")
                    {
                        UrduData += "ٹئی";
                        i++;
                    }
                    else if (check == "ਟਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ٹاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹا";
                            i++;
                        }
                    }
                    else if (check == "ਟੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ٹوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹو";
                            i++;
                        }
                    }
                    else if (check == "ਟੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ٹیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹی";
                            i++;
                        }
                    }
                    else if (check == "ਟਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "ٹں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹ";
                            i++;
                        }
                    }
                    else if (check == "ਟੁ")
                    {
                        UrduData += "ٹ";
                        i++;
                    }
                    else if (check == "ਟੂ")
                    {
                        UrduData += "ٹو";
                        i++;
                    }
                    else if (check == "ਟੌ")
                    {
                        UrduData += "ٹو";
                        i++;
                    }
                    else if (check == "ਟੇ")
                    {
                        UrduData += "ٹے";
                        i++;
                    }
                    else if (check == "ਟੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ٹیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹے";
                            i++;
                        }
                    }
                    else if (check == "ਟੰ")
                    {
                        UrduData += "ٹن";
                        i++;
                    }
                    else if (check == "ਟਂ")
                    {
                        UrduData += "ٹن";
                        i++;
                    }
                    else if (check == "ਟੱ")
                    {
                        UrduData += "ٹ";
                        i++;
                    }
                    else if (check == "ਟ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਟ੍ਰ")
                            {
                                UrduData += "ٹر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ٹ';
                    }
                }
                else
                {
                    UrduData += 'ٹ';
                }
            }
            if (tempChar == 'ਠ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਠਈ")
                    {
                        UrduData += "ٹھئی";
                        i++;
                    }
                    else if (check == "ਠਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ٹھاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹھا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹھا";
                            i++;
                        }
                    }
                    else if (check == "ਠੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ٹھوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹھو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹھو";
                            i++;
                        }
                    }
                    else if (check == "ਠੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ٹھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹھی";
                            i++;
                        }
                    }
                    else if (check == "ਠਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "ٹھں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹھ";
                            i++;
                        }
                    }
                    else if (check == "ਠੁ")
                    {
                        UrduData += "ٹھ";
                        i++;
                    }
                    else if (check == "ਠੂ")
                    {
                        UrduData += "ٹھو";
                        i++;
                    }
                    else if (check == "ਠੌ")
                    {
                        UrduData += "ٹھو";
                        i++;
                    }
                    else if (check == "ਠੇ")
                    {
                        UrduData += "ٹھے";
                        i++;
                    }
                    else if (check == "ਠੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ٹھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹھے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹھے";
                            i++;
                        }
                    }
                    else if (check == "ਠੰ")
                    {
                        UrduData += "ٹھن";
                        i++;
                    }
                    else if (check == "ਠਂ")
                    {
                        UrduData += "ٹھن";
                        i++;
                    }
                    else if (check == "ਠੱ")
                    {
                        UrduData += "ٹھ";
                        i++;
                    }
                    else if (check == "ਠ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਠ੍ਰ")
                            {
                                UrduData += "ٹھر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ٹھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ٹھ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ٹ';
                        UrduData += 'ھ';
                    }
                }
                else
                {
                    UrduData += 'ٹ';
                    UrduData += 'ھ';
                }
            }
            if (tempChar == 'ਡ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਡਈ")
                    {
                        UrduData += "ڈئی";
                        i++;
                    }
                    else if (check == "ਡਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ڈاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڈا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڈا";
                            i++;
                        }
                    }
                    else if (check == "ਡੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ڈوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڈو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڈو";
                            i++;
                        }
                    }
                    else if (check == "ਡੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                        }
                        if (check1 == 'ਂ')
                        {
                            UrduData += "ڈیں";
                            i += 2;
                        }
                        else
                        {
                            UrduData += "ڈی";
                            i++;
                        }
                    }
                    else if (check == "ਡਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                        }
                        if (check1 == 'ੰ')
                        {
                            UrduData += "ڈں";
                            i += 2;
                        }
                        else
                        {
                            UrduData += "ڈ";
                            i++;
                        }
                    }
                    else if (check == "ਡੁ")
                    {
                        UrduData += "ڈ";
                        i++;
                    }
                    else if (check == "ਡੂ")
                    {
                        UrduData += "ڈو";
                        i++;
                    }
                    else if (check == "ਡੌ")
                    {
                        UrduData += "ڈو";
                        i++;
                    }
                    else if (check == "ਡੇ")
                    {
                        UrduData += "ڈے";
                        i++;
                    }
                    else if (check == "ਡੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                        }
                        if (check1 == 'ਂ')
                        {
                            UrduData += "ڈیں";
                            i += 2;
                        }
                        else
                        {
                            UrduData += "ڈے";
                            i++;
                        }
                    }
                    else if (check == "ਡੰ")
                    {
                        UrduData += "ڈن";
                        i++;
                    }
                    else if (check == "ਡਂ")
                    {
                        UrduData += "ڈن";
                        i++;
                    }
                    else if (check == "ਡੱ")
                    {
                        UrduData += "ڈ";
                        i++;
                    }
                    else if (check == "ਡ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਡ੍ਰ")
                            {
                                UrduData += "ڈر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڈ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڈ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ڈ';
                    }
                }
                else
                {
                    UrduData += 'ڈ';
                }
            }
            if (tempChar == 'ਢ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਢਈ")
                    {
                        UrduData += "ڈھئی";
                        i++;
                    }
                    else if (check == "ਢਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ڈھاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڈھا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڈھا";
                            i++;
                        }
                    }
                    else if (check == "ਢੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ڈھو";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڈھو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڈھو";
                            i++;
                        }
                    }
                    else if (check == "ਢੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ڈھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڈھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڈھی";
                            i++;
                        }
                    }
                    else if (check == "ਢਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "ڈھں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڈھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڈھ";
                            i++;
                        }
                    }
                    else if (check == "ਢੁ")
                    {
                        UrduData += "ڈھ";
                        i++;
                    }
                    else if (check == "ਢੂ")
                    {
                        UrduData += "ڈھو";
                        i++;
                    }
                    else if (check == "ਢੌ")
                    {
                        UrduData += "ڈھو";
                        i++;
                    }
                    else if (check == "ਢੇ")
                    {
                        UrduData += "ڈھے";
                        i++;
                    }
                    else if (check == "ਢੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ڈھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڈھے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڈھے";
                            i++;
                        }
                    }
                    else if (check == "ਢੰ")
                    {
                        UrduData += "ڈھن";
                        i++;
                    }
                    else if (check == "ਢਂ")
                    {
                        UrduData += "ڈھن";
                        i++;
                    }
                    else if (check == "ਢੱ")
                    {
                        UrduData += "ڈھ";
                        i++;
                    }
                    else if (check == "ਢ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਢ੍ਰ")
                            {
                                UrduData += "ڈھر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڈھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڈھ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += "ڈھ";
                    }
                }
                else
                {
                    UrduData += "ڈھ";
                }
            }
            if (tempChar == 'ਣ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਣਈ")
                    {
                        UrduData += "ںئی";
                        i++;
                    }
                    else if (check == "ਣਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ںاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ںا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ںا";
                            i++;
                        }
                    }
                    else if (check == "ਣੋ")
                    {
                        UrduData += "ںو";
                        i++;
                    }
                    else if (check == "ਣੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ںیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ںی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ںی";
                            i++;
                        }
                    }
                    else if (check == "ਣਿ")
                    {
                        UrduData += "ں";
                        i++;
                    }
                    else if (check == "ਣੇ")
                    {
                        UrduData += "ںے";
                        i++;
                    }
                    else
                    {
                        UrduData += 'ں';
                    }
                }
                else
                {
                    UrduData += 'ں';
                }
            }
                if (tempChar == 'ਤ')
                {
                    check += tempChar;
                    if (i + 1 < len)
                    {
                        check += PunjabiData[i + 1];
                        if (check == "ਤਈ")
                        {
                            UrduData += "تئی";
                            i++;
                        }
                        else if (check == "ਤਾ")
                        {
                            if (i + 2 < len)
                            {
                                check1 = PunjabiData[i + 2];
                                if (check1 == 'ਂ')
                                {
                                    UrduData += "تاں";
                                    i += 2;
                                }
                                else
                                {
                                    UrduData += "تا";
                                    i++;
                                }
                            }
                            else
                            {
                                UrduData += "تا";
                                i++;
                            }
                        }
                        else if (check == "ਤੋ")
                        {
                            if (i + 2 < len)
                            {
                                check1 = PunjabiData[i + 2];
                                if (check1 == 'ਂ')
                                {
                                    UrduData += "توں";
                                    i += 2;
                                }
                                else
                                {
                                    UrduData += "تو";
                                    i++;
                                }
                            }
                            else
                            {
                                UrduData += "تو";
                                i++;
                            }
                        }
                        else if (check == "ਤੀ")
                        {
                            if (i + 2 < len)
                            {
                                check1 = PunjabiData[i + 2];
                                if (check1 == 'ਂ')
                                {
                                    UrduData += "تیں";
                                    i += 2;
                                }
                                else
                                {
                                    UrduData += "تی";
                                    i++;
                                }
                            }
                            else
                            {
                                UrduData += "تی";
                                i++;
                            }
                        }
                        else if (check == "ਤਿ")
                        {
                            if (i + 2 < len)
                            {
                                check1 = PunjabiData[i + 2];
                                if (check1 == 'ੰ')
                                {
                                    UrduData += "تں";
                                    i += 2;
                                }
                                else
                                {
                                    UrduData += "ت";
                                    i++;
                                }
                            }
                            else
                            {
                                UrduData += "ت";
                                i++;
                            }
                        }
                        else if (check == "ਤੁ")
                        {
                            UrduData += "ت";
                            i++;
                        }
                        else if (check == "ਤੂ")
                        {
                            UrduData += "تو";
                            i++;
                        }
                        else if (check == "ਤੌ")
                        {
                            UrduData += "تو";
                            i++;
                        }
                        else if (check == "ਤੇ")
                        {
                            UrduData += "تے";
                            i++;
                        }
                        else if (check == "ਤੈ")
                        {
                            if (i + 2 < len)
                            {
                                check1 = PunjabiData[i + 2];
                                if (check1 == 'ਂ')
                                {
                                    UrduData += "تیں";
                                    i += 2;
                                }
                                else
                                {
                                    UrduData += "تے";
                                    i++;
                                }
                            }
                            else
                            {
                                UrduData += "تے";
                                i++;
                            }
                        }
                        else if (check == "ਤੰ")
                        {
                            UrduData += "تن";
                            i++;
                        }
                        else if (check == "ਤਂ")
                        {
                            UrduData += "تن";
                            i++;
                        }
                        else if (check == "ਤੱ")
                        {
                            UrduData += "ت";
                            i++;
                        }
                        else if (check == "ਤ੍")
                        {
                            if (i + 2 < len)
                            {
                                check += PunjabiData[i + 2];
                                if (check == "ਤ੍ਰ")
                                {
                                    UrduData += "تر";
                                    i += 2;
                                }
                                else
                                {
                                    UrduData += "ت";
                                    i++;
                                }
                            }
                            else
                            {
                                UrduData += "ت";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'ت';
                        }
                    }
                    else
                    {
                        UrduData += 'ت';
                    }
            }
            if (tempChar == 'ਥ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਥਈ")
                    {
                        UrduData += "تھئی";
                        i++;
                    }
                    else if (check == "ਥਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "تھاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "تھا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "تھا";
                            i++;
                        }
                    }
                    else if (check == "ਥੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "تھوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "تھو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "تھو";
                            i++;
                        }
                    }
                    else if (check == "ਥੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "تھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "تھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "تھی";
                            i++;
                        }
                    }
                    else if (check == "ਥਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "تھں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "تھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "تھ";
                            i++;
                        }
                    }
                    else if (check == "ਥੁ")
                    {
                        UrduData += "تھ";
                        i++;
                    }
                    else if (check == "ਥੂ")
                    {
                        UrduData += "تھو";
                        i++;
                    }
                    else if (check == "ਥੌ")
                    {
                        UrduData += "تھو";
                        i++;
                    }
                    else if (check == "ਥੇ")
                    {
                        UrduData += "تھے";
                        i++;
                    }
                    else if (check == "ਥੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "تھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "تھے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "تھے";
                            i++;
                        }
                    }
                    else if (check == "ਥੰ")
                    {
                        UrduData += "تھن";
                        i++;
                    }
                    else if (check == "ਥਂ")
                    {
                        UrduData += "تھن";
                        i++;
                    }
                    else if (check == "ਥੱ")
                    {
                        UrduData += "تھ";
                        i++;
                    }
                    else if (check == "ਥ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਥ੍ਰ")
                            {
                                UrduData += "تھر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "تھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'ت';
                            UrduData += 'ھ';
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ت';
                        UrduData += 'ھ';
                    }
                }
                else
                {
                    UrduData += 'ت';
                    UrduData += 'ھ';
                }
            }
            if (tempChar == 'ਦ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਦਈ")
                    {
                        UrduData += "دئی";
                        i++;
                    }
                    else if (check == "ਦਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "داں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "دا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "دا";
                            i++;
                        }
                    }
                    else if (check == "ਦੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "دوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "دو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "دو";
                            i++;
                        }
                    }
                    else if (check == "ਦੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "دیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "دی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "دی";
                            i++;
                        }
                    }
                    else if (check == "ਦਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "دں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "د";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "د";
                            i++;
                        }
                    }
                    else if (check == "ਦੁ")
                    {
                        UrduData += "د";
                        i++;
                    }
                    else if (check == "ਦੂ")
                    {
                        UrduData += "دو";
                        i++;
                    }
                    else if (check == "ਦੌ")
                    {
                        UrduData += "دو";
                        i++;
                    }
                    else if (check == "ਦੇ")
                    {
                        UrduData += "دے";
                        i++;
                    }
                    else if (check == "ਦੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "دیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "دے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "دے";
                            i++;
                        }
                    }
                    else if (check == "ਦੰ")
                    {
                        UrduData += "دن";
                        i++;
                    }
                    else if (check == "ਦਂ")
                    {
                        UrduData += "دن";
                        i++;
                    }
                    else if (check == "ਦੱ")
                    {
                        UrduData += "د";
                        i++;
                    }
                    else if (check == "ਦ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਦ੍ਰ")
                            {
                                UrduData += "در";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "د";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'د';
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'د';
                    }
                }
                else
                {
                    UrduData += 'د';
                }
            }
            if (tempChar == 'ਧ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਧਈ")
                    {
                        UrduData += "دھئی";
                        i++;
                    }
                    else if (check == "ਧਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "دھاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "دھا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "دھا";
                            i++;
                        }
                    }
                    else if (check == "ਧੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "دھوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "دھو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "دھو";
                            i++;
                        }
                    }
                    else if (check == "ਧੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "دھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "دھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "دھی";
                            i++;
                        }
                    }
                    else if (check == "ਧਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "دھں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "دھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "دھ";
                            i++;
                        }
                    }
                    else if (check == "ਧੁ")
                    {
                        UrduData += "دھ";
                        i++;
                    }
                    else if (check == "ਧੂ")
                    {
                        UrduData += "دھو";
                        i++;
                    }
                    else if (check == "ਧੌ")
                    {
                        UrduData += "دھو";
                        i++;
                    }
                    else if (check == "ਧੇ")
                    {
                        UrduData += "دھے";
                        i++;
                    }
                    else if (check == "ਧੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ہدھی";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "دھے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "دھے";
                            i++;
                        }
                    }
                    else if (check == "ਧੰ")
                    {
                        UrduData += "دھن";
                        i++;
                    }
                    else if (check == "ਧਂ")
                    {
                        UrduData += "دھن";
                        i++;
                    }
                    else if (check == "ਧੱ")
                    {
                        UrduData += "دھ";
                        i++;
                    }
                    else if (check == "ਧ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਧ੍ਰ")
                            {
                                UrduData += "دھر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "دھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "دھ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'د';
                        UrduData += 'ھ';
                    }
                }
                else
                {
                    UrduData += 'د';
                    UrduData += 'ھ';
                }
            }
            if (tempChar == 'ਨ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਨਈ")
                    {
                        UrduData += "نئی";
                        i++;
                    }
                    else if (check == "ਨਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ناں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "نا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "نا";
                            i++;
                        }
                    }
                    else if (check == "ਨੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "نوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "نو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "نو";
                            i++;
                        }
                    }
                    else if (check == "ਨੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "نیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "نی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "نی";
                            i++;
                        }
                    }
                    else if (check == "ਨਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "نں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ن";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ن";
                            i++;
                        }
                    }
                    else if (check == "ਨੁ")
                    {
                        UrduData += "ن";
                        i++;
                    }
                    else if (check == "ਨੂ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "نوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "نو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "نو";
                            i++;
                        }
                    }
                    else if (check == "ਨੌ")
                    {
                        UrduData += "نو";
                        i++;
                    }
                    else if (check == "ਨੇ")
                    {
                        UrduData += "نے";
                        i++;
                    }
                    else if (check == "ਨੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "نیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "نے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "نے";
                            i++;
                        }
                    }
                    else if (check == "ਨੰ")
                    {
                        UrduData += "نن";
                        i++;
                    }
                    else if (check == "ਨਂ")
                    {
                        UrduData += "نن";
                        i++;
                    }
                    else if (check == "ਨੱ")
                    {
                        UrduData += "ن";
                        i++;
                    }
                    else if (check == "ਨ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਨ੍ਰ")
                            {
                                UrduData += "نر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ن";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ن";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ن';
                    }
                }
                else
                {
                    UrduData += 'ن';
                }
            }
            if (tempChar == 'ਪ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਪਈ")
                    {
                        UrduData += "پئی";
                        i++;
                    }
                    else if (check == "ਪਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "پاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پا";
                            i++;
                        }
                    }
                    else if (check == "ਪੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "پوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پو";
                            i++;
                        }
                    }
                    else if (check == "ਪੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "پیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پی";
                            i++;
                        }
                    }
                    else if (check == "ਪਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "پں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پ";
                            i++;
                        }
                    }
                    else if (check == "ਪੁ")
                    {
                        UrduData += "پ";
                        i++;
                    }
                    else if (check == "ਪੂ")
                    {
                        UrduData += "پو";
                        i++;
                    }
                    else if (check == "ਪੌ")
                    {
                        UrduData += "پو";
                        i++;
                    }
                    else if (check == "ਪੇ")
                    {
                        UrduData += "پے";
                        i++;
                    }
                    else if (check == "ਪੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "پیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پے";
                            i++;
                        }
                    }
                    else if (check == "ਪੰ")
                    {
                        UrduData += "پن";
                        i++;
                    }
                    else if (check == "ਪਂ")
                    {
                        UrduData += "پن";
                        i++;
                    }
                    else if (check == "ਪੱ")
                    {
                        UrduData += "پ";
                        i++;
                    }
                    else if (check == "ਪ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਪ੍ਰ")
                            {
                                UrduData += "پر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'پ';
                    }
                }
                else
                {
                    UrduData += 'پ';
                }
            }
            if (tempChar == 'ਫ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਫਈ")
                    {
                        UrduData += "پھئی";
                        i++;
                    }
                    else if (check == "ਫ਼")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਫ਼ਾ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "فاں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "فا";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "فا";
                                    i += 2;
                                }
                            }
                            else if (check == "ਫ਼ੀ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "فیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "فی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "فی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਫ਼ਿ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "فں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "ف";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "ف";
                                    i += 2;
                                }
                            }
                            else if (check == "ਫ਼ੋ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "فون";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "فو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "فو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਫ਼ੌ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "فوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "فو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "فو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਫ਼ੈ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "فیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "فی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "فی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਫ਼ੇ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "فےں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "فے";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "فے";
                                    i += 2;
                                }
                            }
                            else if (check == "ਫ਼ੁ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "فں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "ف";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "ف";
                                    i += 2;
                                }
                            }
                            else if (check == "ਫ਼ੂ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "فوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "فو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "فو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਫ਼ੰ")
                            {
                                UrduData += "فں";
                                i += 2;
                            }
                            else if (check == "ਫ਼ਂ")
                            {
                                UrduData += "فن";
                                i += 2;
                            }
                            else if (check == "ਫ਼ੱ")
                            {
                                UrduData += "ف";
                                i += 2;
                            }
                            else if (check == "ਫ਼੍")
                            {
                                if (i + 3 < len)
                                {
                                    check += PunjabiData[i + 3];
                                    if (check == "ਫ਼੍ਰ")
                                    {
                                        UrduData += "فر";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += 'ف';
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += 'ف';
                                    i += 2;
                                }
                            }
                            else
                            {
                                UrduData += 'ف';
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'ف';
                            i++;
                        }
                    }
                    else if (check == "ਫਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "پھاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پھا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پھا";
                            i++;
                        }
                    }
                    else if (check == "ਫੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "پھوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پھو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پھو";
                            i++;
                        }
                    }
                    else if (check == "ਫੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "پھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پھی";
                            i++;
                        }
                    }
                    else if (check == "ਫਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "پھں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پھ";
                            i++;
                        }
                    }
                    else if (check == "ਫੁ")
                    {
                        UrduData += "پھ";
                        i++;
                    }
                    else if (check == "ਫੂ")
                    {
                        UrduData += "پھو";
                        i++;
                    }
                    else if (check == "ਫੌ")
                    {
                        UrduData += "پھو";
                        i++;
                    }
                    else if (check == "ਫੇ")
                    {
                        UrduData += "پھے";
                        i++;
                    }
                    else if (check == "ਫੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "پھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پھی";
                            i++;
                        }
                    }
                    else if (check == "ਫੰ")
                    {
                        UrduData += "پھن";
                        i++;
                    }
                    else if (check == "ਫਂ")
                    {
                        UrduData += "پھن";
                        i++;
                    }
                    else if (check == "ਫੱ")
                    {
                        UrduData += "پھ";
                        i++;
                    }
                    else if (check == "ਫ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਫ੍ਰ")
                            {
                                UrduData += "پھر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "پھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "پھ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'پ';
                        UrduData += 'ھ';
                    }
                }
                else
                {
                    UrduData += 'پ';
                    UrduData += 'ھ';
                }
            }
            if (tempChar == 'ਬ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਬਈ")
                    {
                        UrduData += "بئی";
                        i++;
                    }
                    else if (check == "ਬਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "باں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "با";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "با";
                            i++;
                        }
                    }
                    else if (check == "ਬੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "بوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "بو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "بو";
                            i++;
                        }
                    }
                    else if (check == "ਬੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "بیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "بی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "بی";
                            i++;
                        }
                    }
                    else if (check == "ਬਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "بں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ب";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ب";
                            i++;
                        }
                    }
                    else if (check == "ਬੁ")
                    {
                        UrduData += "ب";
                        i++;
                    }
                    else if (check == "ਬੂ")
                    {
                        UrduData += "بو";
                        i++;
                    }
                    else if (check == "ਬੌ")
                    {
                        UrduData += "بو";
                        i++;
                    }
                    else if (check == "ਬੇ")
                    {
                        UrduData += "بے";
                        i++;
                    }
                    else if (check == "ਬੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "بیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "بے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "بے";
                            i++;
                        }
                    }
                    else if (check == "ਬੰ")
                    {
                        UrduData += "بن";
                        i++;
                    }
                    else if (check == "ਬਂ")
                    {
                        UrduData += "بن";
                        i++;
                    }
                    else if (check == "ਬੱ")
                    {
                        UrduData += "ب";
                        i++;
                    }
                    else if (check == "ਬ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਬ੍ਰ")
                            {
                                UrduData += "بر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ب";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ب";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ب';
                    }
                }
                else
                {
                    UrduData += 'ب';
                }
            }
            if (tempChar == 'ਭ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਭਈ")
                    {
                        UrduData += "بھئی";
                        i++;
                    }
                    else if (check == "ਭਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "بھاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "بھا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "بھا";
                            i++;
                        }
                    }
                    else if (check == "ਭੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "بھوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "بھو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "بھو";
                            i++;
                        }
                    }
                    else if (check == "ਭੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "بھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "بھی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "بھی";
                            i++;
                        }
                    }
                    else if (check == "ਭਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "بھں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "بھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "بھ";
                            i++;
                        }
                    }
                    else if (check == "ਭੁ")
                    {
                        UrduData += "بھ";
                        i++;
                    }
                    else if (check == "ਭੂ")
                    {
                        UrduData += "بھو";
                        i++;
                    }
                    else if (check == "ਭੌ")
                    {
                        UrduData += "بھو";
                        i++;
                    }
                    else if (check == "ਭੇ")
                    {
                        UrduData += "بھے";
                        i++;
                    }
                    else if (check == "ਭੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "بھیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "بھے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "بھے";
                            i++;
                        }
                    }
                    else if (check == "ਭੰ")
                    {
                        UrduData += "بھن";
                        i++;
                    }
                    else if (check == "ਭਂ")
                    {
                        UrduData += "بھن";
                        i++;
                    }
                    else if (check == "ਭੱ")
                    {
                        UrduData += "بھ";
                        i++;
                    }
                    else if (check == "ਭ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਭ੍ਰ")
                            {
                                UrduData += "بھر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "بھ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "بھ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ب';
                        UrduData += 'ھ';
                    }
                }
                else
                {
                    UrduData += 'ب';
                    UrduData += 'ھ';
                }
            }
            if (tempChar == 'ਮ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਮਈ")
                    {
                        UrduData += "مئی";
                        i++;
                    }
                    else if (check == "ਮਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ماں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ما";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ما";
                            i++;
                        }
                    }
                    else if (check == "ਮੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "موں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "مو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "مو";
                            i++;
                        }
                    }
                    else if (check == "ਮੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "میں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "می";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "می";
                            i++;
                        }
                    }
                    else if (check == "ਮਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "مں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "م";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "م";
                            i++;
                        }
                    }
                    else if (check == "ਮੁ")
                    {
                        UrduData += "م";
                        i++;
                    }
                    else if (check == "ਮੂ")
                    {
                        UrduData += "مو";
                        i++;
                    }
                    else if (check == "ਮੌ")
                    {
                        UrduData += "مو";
                        i++;
                    }
                    else if (check == "ਮੇ")
                    {
                        UrduData += "مے";
                        i++;
                    }
                    else if (check == "ਮੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "میں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "مے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "مے";
                            i++;
                        }
                    }
                    else if (check == "ਮੰ")
                    {
                        UrduData += "من";
                        i++;
                    }
                    else if (check == "ਮਂ")
                    {
                        UrduData += "من";
                        i++;
                    }
                    else if (check == "ਮੱ")
                    {
                        UrduData += "م";
                        i++;
                    }
                    else if (check == "ਮ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਮ੍ਰ")
                            {
                                UrduData += "مر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "م";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "م";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'م';
                    }
                }
                else
                {
                    UrduData += 'م';
                }
            }
            if (tempChar == 'ਯ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਯਈ")
                    {
                        UrduData += "ئی";
                        i++;
                    }
                    else if (check == "ਯਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "یاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "یا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "یا";
                            i++;
                        }
                    }
                    else if (check == "ਯੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "یوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "یو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "یو";
                            i++;
                        }
                    }
                    else if (check == "ਯੁ")
                    {
                        UrduData += "یو";
                        i++;
                    }
                    else if (check == "ਯੂ")
                    {
                        UrduData += "یو";
                        i++;
                    }
                    else if (check == "ਯੌ")
                    {
                        UrduData += "یو";
                        i++;
                    }
                    else if (check == "ਯੇ")
                    {
                        UrduData += "یے";
                        i++;
                    }
                    else if (check == "ਯੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "یں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "یے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "یے";
                            i++;
                        }
                    }
                    else if (check == "ਯੰ")
                    {
                        UrduData += "ین";
                        i++;
                    }
                    else if (check == "ਯਂ")
                    {
                        UrduData += "ین";
                        i++;
                    }
                    else
                    {
                        UrduData += 'ی';
                    }
                }
                else
                {
                    UrduData += 'ی';
                }
            }
            if (tempChar == 'ਰ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਰਈ")
                    {
                        UrduData += "رئی";
                        i++;
                    }
                    else if (check == "ਰਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "راں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "را";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "را";
                            i++;
                        }
                    }
                    else if (check == "ਰੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "روں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "رو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "رو";
                            i++;
                        }
                    }
                    else if (check == "ਰੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ریں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ری";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ری";
                            i++;
                        }
                    }
                    else if (check == "ਰਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "رں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ر";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ر";
                            i++;
                        }
                    }
                    else if (check == "ਰੁ")
                    {
                        UrduData += "ر";
                        i++;
                    }
                    else if (check == "ਰੂ")
                    {
                        UrduData += "رو";
                        i++;
                    }
                    else if (check == "ਰੌ")
                    {
                        UrduData += "رو";
                        i++;
                    }
                    else if (check == "ਰੇ")
                    {
                        UrduData += "رے";
                        i++;
                    }
                    else if (check == "ਰੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ریں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "رے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "رے";
                            i++;
                        }
                    }
                    else if (check == "ਰੰ")
                    {
                        UrduData += "رن";
                        i++;
                    }
                    else if (check == "ਰਂ")
                    {
                        UrduData += "رن";
                        i++;
                    }
                    else if (check == "ਰੱ")
                    {
                        UrduData += "ر";
                        i++;
                    }
                    else
                    {
                        UrduData += 'ر';
                    }
                }
                else
                {
                    UrduData += 'ر';
                }
            }
            if (tempChar == 'ਲ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਲਈ")
                    {
                        UrduData += "لئی";
                        i++;
                    }
                    else if (check == "ਲ਼")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਲ਼ਾ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "لاں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "لا";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "لا";
                                    i += 2;
                                }
                            }
                            else if (check == "ਲ਼ੀ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "فیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "لی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "لی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਲ਼ਿ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "لں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "ل";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "ل";
                                    i += 2;
                                }
                            }
                            else if (check == "ਲ਼ੋ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "لون";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "لو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "لو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਲ਼ੌ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "لوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "لو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "لو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਲ਼ੈ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "لیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "لی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "لی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਲ਼ੇ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "لےں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "لے";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "لے";
                                    i += 2;
                                }
                            }
                            else if (check == "ਲ਼ੁ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "لں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "ل";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "ل";
                                    i += 2;
                                }
                            }
                            else if (check == "ਲ਼ੂ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "لوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "لو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "لو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਲ਼ੰ")
                            {
                                UrduData += "لں";
                                i += 2;
                            }
                            else if (check == "ਲ਼ਂ")
                            {
                                UrduData += "لن";
                                i += 2;
                            }
                            else if (check == "ਲ਼ੱ")
                            {
                                UrduData += "ل";
                                i += 2;
                            }
                            else if (check == "ਲ਼੍ਰ")
                            {
                                UrduData += "لر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += 'ل';
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'ل';
                            i++;
                        }
                    }
                    else if (check == "ਲਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "لاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "لا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "لا";
                            i++;
                        }
                    }
                    else if (check == "ਲੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "لوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "لو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "لو";
                            i++;
                        }
                    }
                    else if (check == "ਲੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "لیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "لی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "لی";
                            i++;
                        }
                    }
                    else if (check == "ਲਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "لں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ل";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ل";
                            i++;
                        }
                    }
                    else if (check == "ਲੁ")
                    {
                        UrduData += "ل";
                        i++;
                    }
                    else if (check == "ਲੂ")
                    {
                        UrduData += "لو";
                        i++;
                    }
                    else if (check == "ਲੌ")
                    {
                        UrduData += "لو";
                        i++;
                    }
                    else if (check == "ਲੇ")
                    {
                        UrduData += "لے";
                        i++;
                    }
                    else if (check == "ਲੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "لیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "لے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "لے";
                            i++;
                        }
                    }
                    else if (check == "ਲੰ")
                    {
                        UrduData += "لن";
                        i++;
                    }
                    else if (check == "ਲਂ")
                    {
                        UrduData += "لن";
                        i++;
                    }
                    else if (check == "ਲੱ")
                    {
                        UrduData += "ل";
                        i++;
                    }
                    else if (check == "ਲ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਲ੍ਰ")
                            {
                                UrduData += "لر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ل";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ل";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ل';
                    }
                }
                else
                {
                    UrduData += 'ل';
                }
            }
            if (tempChar == 'ਵ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਵਈ")
                    {
                        UrduData += "وئی";
                        i++;
                    }
                    else if (check == "ਵਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "واں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "وا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "وا";
                            i++;
                        }
                    }
                    else if (check == "ਵੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ووں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "وو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "وو";
                            i++;
                        }
                    }
                    else if (check == "ਵੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ویں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "وی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "وی";
                            i++;
                        }
                    }
                    else if (check == "ਵਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "وں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "و";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "و";
                            i++;
                        }
                    }
                    else if (check == "ਵੁ")
                    {
                        UrduData += "و";
                        i++;
                    }
                    else if (check == "ਵੂ")
                    {
                        UrduData += "و";
                        i++;
                    }
                    else if (check == "ਵੌ")
                    {
                        UrduData += "وو";
                        i++;
                    }
                    else if (check == "ਵੇ")
                    {
                        UrduData += "وے";
                        i++;
                    }
                    else if (check == "ਵੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ویں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "وی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "وی";
                            i++;
                        }
                    }
                    else if (check == "ਵੰ")
                    {
                        UrduData += "ون";
                        i++;
                    }
                    else if (check == "ਵਂ")
                    {
                        UrduData += "ون";
                        i++;
                    }
                    else if (check == "ਵੱ")
                    {
                        UrduData += "و";
                        i++;
                    }
                    else if (check == "ਵ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਵ੍ਰ")
                            {
                                UrduData += "ور";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "و";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "و";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'و';
                    }
                }
                else
                {
                    UrduData += 'و';
                }
            }
            if (tempChar == 'ੜ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ੜਈ")
                    {
                        UrduData += "ڑئی";
                        i++;
                    }
                    else if (check == "ੜਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ڑاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڑا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڑا";
                            i++;
                        }
                    }
                    else if (check == "ੜੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ڑوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڑو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڑو";
                            i++;
                        }
                    }
                    else if (check == "ੜੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ڑیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڑی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڑی";
                            i++;
                        }
                    }
                    else if (check == "ੜਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "ڑں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڑ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڑ";
                            i++;
                        }
                    }
                    else if (check == "ੜੌ")
                    {
                        UrduData += "ڑو";
                        i++;
                    }
                    else if (check == "ੜੇ")
                    {
                        UrduData += "ڑے";
                        i++;
                    }
                    else if (check == "ੜੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ڑیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ڑے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ڑے";
                            i++;
                        }
                    }
                    else if (check == "ੜਂ")
                    {
                        UrduData += "ڑن";
                        i++;
                    }
                    else if (check == "ੜੱ")
                    {
                        UrduData += "ڑ";
                        i++;
                    }
                    else
                    {
                        UrduData += 'ڑ';
                    }
                }
                else
                {
                    UrduData += 'ڑ';
                }
            }
            if (tempChar == 'ਸ਼')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਸ਼ਈ")
                    {
                        UrduData += "شئی";
                        i++;
                    }
                    else if (check == "ਸ਼ਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "شاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "شا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "شا";
                            i++;
                        }
                    }
                    else if (check == "ਸ਼ੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "شوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "شو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "شو";
                            i++;
                        }
                    }
                    else if (check == "ਸ਼ੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "شیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "شی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "شی";
                            i++;
                        }
                    }
                    else if (check == "ਸ਼ਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "شں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ش";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ش";
                            i++;
                        }
                    }
                    else if (check == "ਸ਼ੁ")
                    {
                        UrduData += "ش";
                        i++;
                    }
                    else if (check == "ਸ਼ੂ")
                    {
                        UrduData += "شو";
                        i++;
                    }
                    else if (check == "ਸ਼ੌ")
                    {
                        UrduData += "شو";
                        i++;
                    }
                    else if (check == "ਸ਼ੇ")
                    {
                        UrduData += "شے";
                        i++;
                    }
                    else if (check == "ਸ਼ੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "شیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "شے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "شے";
                            i++;
                        }
                    }
                    else if (check == "ਸ਼ੰ")
                    {
                        UrduData += "شن";
                        i++;
                    }
                    else if (check == "ਸ਼ਂ")
                    {
                        UrduData += "شن";
                        i++;
                    }
                    else if (check == "ਸ਼ੱ")
                    {
                        UrduData += "ش";
                        i++;
                    }
                    else if (check == "ਸ਼੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਸ਼੍ਰ")
                            {
                                UrduData += "شر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ش";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ش";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ش';
                    }
                }
                else
                {
                    UrduData += 'ش';
                }
            }
            if (tempChar == 'ਸ')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਸਈ")
                    {
                        UrduData += "سئی";
                        i++;
                    }
                    else if (check == "ਸ਼")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਸ਼ਾ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "شاں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "شا";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "شا";
                                    i += 2;
                                }
                            }
                            else if (check == "ਸ਼ੋ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "شوں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "شو";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "شو";
                                    i += 2;
                                }
                            }
                            else if (check == "ਸ਼ੀ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "شیں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "شی";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "شی";
                                    i += 2;
                                }
                            }
                            else if (check == "ਸ਼ਿ")
                            {
                                if (i + 3 < len)
                                {
                                    check1 = PunjabiData[i + 3];
                                    if (check1 == 'ੰ')
                                    {
                                        UrduData += "شں";
                                        i += 3;
                                    }
                                    else
                                    {
                                        UrduData += "ش";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "ش";
                                    i += 2;
                                }
                            }
                            else if (check == "ਸ਼ੁ")
                            {
                                UrduData += "ش";
                                i += 2;
                            }
                            else if (check == "ਸ਼ੂ")
                            {
                                UrduData += "شو";
                                i += 2;
                            }
                            else if (check == "ਸ਼ੌ")
                            {
                                UrduData += "شو";
                                i += 2;
                            }
                            else if (check == "ਸ਼ੇ")
                            {
                                UrduData += "شے";
                                i += 2;
                            }
                            else if (check == "ਸ਼ੈ")
                            {
                                if (i + 2 < len)
                                {
                                    check1 = PunjabiData[i + 2];
                                    if (check1 == 'ਂ')
                                    {
                                        UrduData += "شیں";
                                        i += 2;
                                    }
                                    else
                                    {
                                        UrduData += "شے";
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    UrduData += "شے";
                                    i += 2;
                                }
                            }
                            else if (check == "ਸ਼ੰ")
                            {
                                UrduData += "شن";
                                i += 2;
                            }
                            else if (check == "ਸ਼ਂ")
                            {
                                UrduData += "شن";
                                i += 2;
                            }
                            else if (check == "ਸ਼ੱ")
                            {
                                UrduData += "ش";
                                i += 2;
                            }
                            else if (check == "ਸ਼੍ਰ")
                            {
                                UrduData += "شر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += 'ش';
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += 'ش';
                            i++;
                        }
                    }
                    else if (check == "ਸਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ساں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "سا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "سا";
                            i++;
                        }
                    }
                    else if (check == "ਸੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "سوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "سو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "سو";
                            i++;
                        }
                    }
                    else if (check == "ਸੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "سیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "سی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "سی";
                            i++;
                        }
                    }
                    else if (check == "ਸਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "سں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "س";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "س";
                            i++;
                        }
                    }
                    else if (check == "ਸੁ")
                    {
                        UrduData += "س";
                        i++;
                    }
                    else if (check == "ਸੂ")
                    {
                        UrduData += "سو";
                        i++;
                    }
                    else if (check == "ਸੌ")
                    {
                        UrduData += "سو";
                        i++;
                    }
                    else if (check == "ਸੇ")
                    {
                        UrduData += "سے";
                        i++;
                    }
                    else if (check == "ਸੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "سیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "سے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "سے";
                            i++;
                        }
                    }
                    else if (check == "ਸੰ")
                    {
                        UrduData += "سن";
                        i++;
                    }
                    else if (check == "ਸਂ")
                    {
                        UrduData += "سن";
                        i++;
                    }
                    else if (check == "ਸੱ")
                    {
                        UrduData += "س";
                        i++;
                    }
                    else if (check == "ਸ੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਸ੍ਰ")
                            {
                                UrduData += "سر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "س";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "س";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'س';
                    }
                }
                else
                {
                    UrduData += 'س';
                }
            }
            if (tempChar == 'ਜ਼')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਜ਼ਈ")
                    {
                        UrduData += "زئی";
                        i++;
                    }
                    else if (check == "ਜ਼ਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "زاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ظا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ظا";
                            i++;
                        }
                    }
                    else if (check == "ਜ਼ੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ظوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ظو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ظو";
                            i++;
                        }
                    }
                    else if (check == "ਜ਼ੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ظیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ظی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ظی";
                            i++;
                        }
                    }
                    else if (check == "ਜ਼ਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "ظں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ظ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ظ";
                            i++;
                        }
                    }
                    else if (check == "ਜ਼ੁ")
                    {
                        UrduData += "ظ";
                        i++;
                    }
                    else if (check == "ਜ਼ੂ")
                    {
                        UrduData += "ظو";
                        i++;
                    }
                    else if (check == "ਜ਼ੌ")
                    {
                        UrduData += "ظو";
                        i++;
                    }
                    else if (check == "ਜ਼ੇ")
                    {
                        UrduData += "ظے";
                        i++;
                    }
                    else if (check == "ਜ਼ੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "ظیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ظے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ظے";
                            i++;
                        }
                    }
                    else if (check == "ਜ਼ੰ")
                    {
                        UrduData += "ظں";
                        i++;
                    }
                    else if (check == "ਜ਼ਂ")
                    {
                        UrduData += "ظں";
                        i++;
                    }
                    else if (check == "ਜ਼ੱ")
                    {
                        UrduData += "ظ";
                        i++;
                    }
                    else if (check == "ਜ਼੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਜ਼੍ਰ")
                            {
                                UrduData += "ظر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ظ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ظ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += 'ظ';
                    }
                }
                else
                {
                    UrduData += 'ظ';
                }
            }
            if (tempChar == 'ਫ਼')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਫ਼ਈ")
                    {
                        UrduData += "فئی";
                        i++;
                    }
                    else if (check == "ਫ਼ਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "فاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "فا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "فا";
                            i++;
                        }
                    }
                    else if (check == "ਫ਼ੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "فوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "فو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "فو";
                            i++;
                        }
                    }
                    else if (check == "ਫ਼ੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "فیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "فی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "فی";
                            i++;
                        }
                    }
                    else if (check == "ਫ਼ਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "فں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ف";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ف";
                            i++;
                        }
                    }
                    else if (check == "ਫ਼ੁ")
                    {
                        UrduData += "ف";
                        i++;
                    }
                    else if (check == "ਫ਼ੂ")
                    {
                        UrduData += "فو";
                        i++;
                    }
                    else if (check == "ਫ਼ੌ")
                    {
                        UrduData += "فو";
                        i++;
                    }
                    else if (check == "ਫ਼ੇ")
                    {
                        UrduData += "فے";
                        i++;
                    }
                    else if (check == "ਫ਼ੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "فیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "فے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "فے";
                            i++;
                        }
                    }
                    else if (check == "ਫ਼ੰ")
                    {
                        UrduData += "فں";
                        i++;
                    }
                    else if (check == "ਫ਼ਂ")
                    {
                        UrduData += "فں";
                        i++;
                    }
                    else if (check == "ਫ਼ੱ")
                    {
                        UrduData += "ف";
                        i++;
                    }
                    else if (check == "ਫ਼੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਫ਼੍ਰ")
                            {
                                UrduData += "فر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ف";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ف";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += "ف";
                    }
                }
                else
                {
                    UrduData += "ف";
                }
            }
            if (tempChar == 'ਲ਼')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਲ਼ਈ")
                    {
                        UrduData += "لئی";
                        i++;
                    }
                    else if (check == "ਲ਼ਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "لاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "لا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "لا";
                            i++;
                        }
                    }
                    else if (check == "ਲ਼ੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "لوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "لو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "لو";
                            i++;
                        }
                    }
                    else if (check == "ਲ਼ੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "لیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "لی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "لی";
                            i++;
                        }
                    }
                    else if (check == "ਲ਼ਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "لں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "ل";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "ل";
                            i++;
                        }
                    }
                    else if (check == "ਲ਼ੁ")
                    {
                        UrduData += "ل";
                        i++;
                    }
                    else if (check == "ਲ਼ੂ")
                    {
                        UrduData += "لو";
                        i++;
                    }
                    else if (check == "ਲ਼ੌ")
                    {
                        UrduData += "لو";
                        i++;
                    }
                    else if (check == "ਲ਼ੇ")
                    {
                        UrduData += "لے";
                        i++;
                    }
                    else if (check == "ਲ਼ੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "لیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "لے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "لے";
                            i++;
                        }
                    }
                    else if (check == "ਲ਼ੰ")
                    {
                        UrduData += "لں";
                        i++;
                    }
                    else if (check == "ਲ਼ਂ")
                    {
                        UrduData += "لں";
                        i++;
                    }
                    else if (check == "ਲ਼ੱ")
                    {
                        UrduData += "ل";
                        i++;
                    }
                    else
                    {
                        UrduData += "ل";
                    }
                }
                else
                {
                    UrduData += "ل";
                }
            }
            if (tempChar == 'ਗ਼')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਗ਼ਈ")
                    {
                        UrduData += "غئی";
                        i++;
                    }
                    else if (check == "ਗ਼ਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "غاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "غا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "غا";
                            i++;
                        }
                    }
                    else if (check == "ਗ਼ੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "غوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "غو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "غو";
                            i++;
                        }
                    }
                    else if (check == "ਗ਼ੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "غیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "غی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "غی";
                            i++;
                        }
                    }
                    else if (check == "ਗ਼ਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "غں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "غ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "غ";
                            i++;
                        }
                    }
                    else if (check == "ਗ਼ੁ")
                    {
                        UrduData += "غ";
                        i++;
                    }
                    else if (check == "ਗ਼ੂ")
                    {
                        UrduData += "غو";
                        i++;
                    }
                    else if (check == "ਗ਼ੌ")
                    {
                        UrduData += "غو";
                        i++;
                    }
                    else if (check == "ਗ਼ੇ")
                    {
                        UrduData += "غے";
                        i++;
                    }
                    else if (check == "ਗ਼ੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "غیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "غے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "غے";
                            i++;
                        }
                    }
                    else if (check == "ਗ਼ੰ")
                    {
                        UrduData += "غں";
                        i++;
                    }
                    else if (check == "ਗ਼ਂ")
                    {
                        UrduData += "غں";
                        i++;
                    }
                    else if (check == "ਗ਼ੱ")
                    {
                        UrduData += "غ";
                        i++;
                    }
                    else if (check == "ਗ਼੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਗ਼੍ਰ")
                            {
                                UrduData += "غر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "غ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "غ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += "غ";
                    }
                }
                else
                {
                    UrduData += "غ";
                }
            }
            if (tempChar == 'ਖ਼')
            {
                check += tempChar;
                if (i + 1 < len)
                {
                    check += PunjabiData[i + 1];
                    if (check == "ਖ਼ਈ")
                    {
                        UrduData += "خئی";
                        i++;
                    }
                    else if (check == "ਖ਼ਾ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "خاں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "خا";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "خا";
                            i++;
                        }
                    }
                    else if (check == "ਖ਼ੋ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "خوں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "خو";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "خو";
                            i++;
                        }
                    }
                    else if (check == "ਖ਼ੀ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "خیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "خی";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "خی";
                            i++;
                        }
                    }
                    else if (check == "ਖ਼ਿ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ੰ')
                            {
                                UrduData += "خں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "خ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "خ";
                            i++;
                        }
                    }
                    else if (check == "ਖ਼ੁ")
                    {
                        UrduData += "خ";
                        i++;
                    }
                    else if (check == "ਖ਼ੂ")
                    {
                        UrduData += "خو";
                        i++;
                    }
                    else if (check == "ਖ਼ੌ")
                    {
                        UrduData += "خو";
                        i++;
                    }
                    else if (check == "ਖ਼ੇ")
                    {
                        UrduData += "خے";
                        i++;
                    }
                    else if (check == "ਖ਼ੈ")
                    {
                        if (i + 2 < len)
                        {
                            check1 = PunjabiData[i + 2];
                            if (check1 == 'ਂ')
                            {
                                UrduData += "خیں";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "خے";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "خے";
                            i++;
                        }
                    }
                    else if (check == "ਖ਼ੰ")
                    {
                        UrduData += "خم";
                        i++;
                    }
                    else if (check == "ਖ਼ਂ")
                    {
                        UrduData += "خں";
                        i++;
                    }
                    else if (check == "ਖ਼ੱ")
                    {
                        UrduData += "خ";
                        i++;
                    }
                    else if (check == "ਖ਼੍")
                    {
                        if (i + 2 < len)
                        {
                            check += PunjabiData[i + 2];
                            if (check == "ਖ਼੍ਰ")
                            {
                                UrduData += "خر";
                                i += 2;
                            }
                            else
                            {
                                UrduData += "خ";
                                i++;
                            }
                        }
                        else
                        {
                            UrduData += "خ";
                            i++;
                        }
                    }
                    else
                    {
                        UrduData += "خ";
                    }
                }
                else
                {
                    UrduData += "خ";
                }
            }
            check = null;
        }
        txtUrdu.Text = UrduData;
    }
}