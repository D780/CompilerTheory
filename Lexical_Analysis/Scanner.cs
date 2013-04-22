using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical_Analysis
{
    class Scanner
    {
        string scannerSource;
        int pos = 0;
        public int Pos
        {
            get { return this.pos; }
            set { this.pos = value; }
        }
        public Scanner(string source)
        {
            scannerSource = source;
        }

        public string scan()
        {
            while (pos < scannerSource.Length)
            {
                char ch = scannerSource[pos++];
                string returnStr;
                if (ch == ' '||ch == '\r'||ch == '\n') continue;
                StringBuilder sb = new StringBuilder();
                if (char.IsLetter(ch))
                {
                    pos--;
                    while (pos < scannerSource.Length && char.IsLetterOrDigit(ch))
                    {
                        ch = scannerSource[pos++];
                        sb.Append(ch);
                    }
                    pos--;
                    sb.Remove(sb.Length-1,1);
                    returnStr = sb.ToString();
                    if (Main.KeyWords.ContainsKey(returnStr))
                    {
                        return "(" + Main.KeyWords[returnStr] + "," + returnStr + ")";
                    }
                    else
                    {
                        return "(20," + returnStr + ")";
                    }
                }
                else if (char.IsDigit(ch))
                {
                    pos--;
                    while (pos < scannerSource.Length && char.IsDigit(ch))
                    {
                        ch = scannerSource[pos++];
                        sb.Append(ch);
                    }
                    pos--;

                    sb.Remove(sb.Length - 1, 1);
                    returnStr = sb.ToString();

                    return "(" + 21 + "," + returnStr + ")";
                }                
                else
                {
                    switch (ch)
                    {
                        case '+': return "(22," + ch + ")";
                        case '-': return "(23," + ch + ")";
                        case '*': return "(24," + ch + ")";
                        case '/': 
                            if (pos < scannerSource.Length && scannerSource[pos] == '*')
                            {
                                pos++;
                                while (pos < scannerSource.Length && scannerSource[pos] != '*')
                                {
                                    pos++;
                                }
                                pos += 2;
                                return "";
                            }
                            else if(pos < scannerSource.Length && scannerSource[pos] == '/'){
                                while (pos < scannerSource.Length && scannerSource[pos] != '\r')
                                {
                                    pos++;
                                }
                                return "";
                            }else
                            {
                                return "(25," + ch + ")";
                            }
                        case '%': return "(26," + ch + ")";
                        case '>':
                            if (pos < scannerSource.Length && scannerSource[pos] == '=')
                            {
                                pos++; return "(28,>=)";
                            }
                            else
                            {
                                return "(28,>)";
                            }
                        case '<':
                            if (pos < scannerSource.Length && scannerSource[pos] == '=')
                            {
                                pos++; return "(30,<=)";
                            }
                            else
                            {
                                return "(29,<)";
                            }
                        case '=':
                            if (pos < scannerSource.Length && scannerSource[pos] == '=')
                            {
                                pos++; return "(32,==)";
                            }
                            else
                            {
                                return "(31,=)";
                            }
                        case '!':
                            if (pos < scannerSource.Length && scannerSource[pos] == '=')
                            {
                                pos++; return "(33,!=)";
                            }
                            else
                            {
                                return "(35,!)";
                            }
                        case '^': return "(34," + ch + ")";
                        case '(': return "(36," + ch + ")";
                        case ')': return "(37," + ch + ")";
                        case ';': return "(38," + ch + ")";
                        case '\"': return "(39," + ch + ")";
                        case '\'': return "(40," + ch + ")";
                        case '[': return "(41," + ch + ")";
                        case ']': return "(42," + ch + ")";
                        case '{': return "(43," + ch + ")";
                        case '}': return "(44," + ch + ")";
                        case '.': return "(45," + ch + ")";
                        case '#': return "(46," + ch + ")";
                        case ',': return "(47," + ch + ")";
                        case '&':
                            if (pos < scannerSource.Length && scannerSource[pos] == '&')
                            {
                                pos++; return "(49,&&)";
                            }
                            else
                            {
                                return "(48,&)";
                            }
                        case '|':
                            if (pos < scannerSource.Length && scannerSource[pos] == '|')
                            {
                                pos++; return "(51,||)";
                            }
                            else
                            {
                                return "(50,|)";
                            }
                        default: return "(404," + ch + ")";
                    }
                }
            } 
            return null;
        }
    }
}
