using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /*
 Interface: IEncryptable.cs
 Author: Hamza Saleh,000887384
 Date: October 31,2023
 Purpose: This interface has two methods that classes making use of must
 implement.
 This code is not to be altered.
 */
    /// <summary>
    /// The class implementing the Encrypt() method will use some sort
    /// of encryption algorithm to return some encrypted data.
    ///
    /// The class implementing the Decrypt() method will use (presumably)
    /// the same encryption algorithm to return a decrypted string.
    /// </summary>
    public interface IEncryptable
    {
        string Encrypt(string input);
        string Decrypt(string input);
    }

}
