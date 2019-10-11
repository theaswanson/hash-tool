using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crisp_hash_tool
{
    public interface IHasher
    {
        string GetBase64();
        string GetMD4();
        string GetMD5();
        string GetSHA1();
        string GetSHA256();
        string GetSHA512();
        string GetWhirlpool();
    }
}
