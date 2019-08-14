using System;
using System.Collections.Generic;
using System.Text;

namespace Updater.UpdateService.Interface
{
    public interface ISignatureGenerator
    {
        string GetSignature(string filePath);
    }
}
