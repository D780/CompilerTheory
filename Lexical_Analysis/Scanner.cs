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
        /// <summary>
        /// 当前扫描位置
        /// </summary>
        int pos = 0;
        public int Pos
        {
            get { return this.pos; }
            private set { this.pos = value; }
        }        
        /// <summary>
        /// 上一次扫描的字串的行号
        /// </summary>
        int line=1;
        public int Line
        {
            get { return this.line; }
            private set { this.line = value; }
        }
        /// <summary>
        /// 上一次扫描的字串的种别码
        /// </summary>
        int syn ;
        public int Syn
        {
            get { return this.syn; }
            private set { this.syn = value; }
        }
        /// <summary>
        /// 上一次扫描的字串的值
        /// </summary>
        string word;
        public string Word
        {
            get { return this.word; }
            private set { this.word = value; }
        }

        public Scanner(string source)
        {
            scannerSource = source;
        }
        /// <summary>
        /// 从Pos开始扫描一个字串
        /// </summary>
        /// <returns></returns>
        public string scan()
        {
            while (pos < scannerSource.Length)
            {
                char ch = scannerSource[pos++];
                if (ch == ' '||ch=='\r') continue;
                if (ch == '\n' && scannerSource[pos - 2] == '\r')
                {
                    line++;
                    continue;
                }
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
                    word = sb.ToString();
                    if (Main.KeyWords.ContainsKey(word))
                    {
                        syn = Main.KeyWords[word];
                        return "<" + syn + "," + word + ">";
                    }
                    else
                    {
                        syn = 20;
                        return "<20," + word + ">";
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
                    word = sb.ToString();
                    syn = 21;
                    return "<" + syn + "," + word + ">";
                }                
                else
                {
                    word = ch.ToString();
                    switch (ch)
                    {
                        case '+': syn = 22; return "<22," + ch + ">";
                        case '-': syn = 23; return "<23," + ch + ">";
                        case '*': syn = 24; return "<24," + ch + ">";
                        case '/': 
                            if (pos < scannerSource.Length && scannerSource[pos] == '*')
                            {
                                word="/*注释*/";
                                syn = -1;
                                pos++;
                                while (pos < scannerSource.Length && scannerSource[pos] != '*')
                                {
                                    pos++;
                                }
                                pos += 2;
                                return "";
                            }
                            else if(pos < scannerSource.Length && scannerSource[pos] == '/'){
                                word = "//注释";
                                syn = -1;
                                while (pos < scannerSource.Length && scannerSource[pos] != '\r')
                                {
                                    pos++;
                                }
                                return "";
                            }else
                            {
                                syn = 25; 
                                return "<25," + ch + ">";
                            }
                        case '%': syn = 26; return "<26," + ch + ">";
                        case '>':
                            if (pos < scannerSource.Length && scannerSource[pos] == '=')
                            {
                                word = ">=";
                                syn = 28; 
                                pos++; return "<28,>=>";
                            }
                            else
                            {
                                syn = 27; 
                                return "<27,>>";
                            }
                        case '<':
                            if (pos < scannerSource.Length && scannerSource[pos] == '=')
                            {
                                word = "<=";
                                syn = 30; 
                                pos++; return "<30,<=>";
                            }
                            else
                            {
                                syn = 29; 
                                return "<29,<>";
                            }
                        case '=':
                            if (pos < scannerSource.Length && scannerSource[pos] == '=')
                            {
                                word = "==";
                                syn = 32; 
                                pos++; return "<32,==>";
                            }
                            else
                            {
                                syn = 31; 
                                return "<31,=>";
                            }
                        case '!':
                            if (pos < scannerSource.Length && scannerSource[pos] == '=')
                            {
                                syn = 33; 
                                pos++; return "<33,!=>";
                            }
                            else
                            {
                                syn = 35; 
                                return "<35,!>";
                            }
                        case '^': syn = 34; return "<34," + ch + ">";
                        case '(': syn = 36; return "<36," + ch + ">";
                        case ')': syn = 37; return "<37," + ch + ">";
                        case ';': syn = 38; return "<38," + ch + ">";
                        case '\"': syn = 39; return "<39," + ch + ">";
                        case '\'': syn = 40; return "<40," + ch + ">";
                        case '[': syn = 41; return "<41," + ch + ">";
                        case ']': syn = 42; return "<42," + ch + ">";
                        case '{': syn = 43; return "<43," + ch + ">";
                        case '}': syn = 44; return "<44," + ch + ">";
                        case '.': syn = 45; return "<45," + ch + ">";
                        case '#': syn = 46; return "<46," + ch + ">";
                        case ',': syn = 47; return "<47," + ch + ">";
                        case '&':
                            if (pos < scannerSource.Length && scannerSource[pos] == '&')
                            {
                                word = "&&";
                                syn = 49; 
                                pos++; return "<49,&&>";
                            }
                            else
                            {
                                syn = 48; 
                                return "<48,&>";
                            }
                        case '|':
                            if (pos < scannerSource.Length && scannerSource[pos] == '|')
                            {
                                word = "||";
                                syn = 51; 
                                pos++; return "<51,||>";
                            }
                            else
                            {
                                syn = 50; 
                                return "<50,|>";
                            }
                        default: 
                            syn = 404; 
                            return "<404," + ch + ">";
                    }
                }
            } 
            return null;
        }
    
    }
}
