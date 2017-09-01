using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _ReadWrite_ReadWriteInt32_ReadWriteInt32_
    {
        [Fact]
        public void _ReadWrite_ReadWriteInt32_ReadWriteInt32_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\ReadWrite\\ReadWriteInt32\\ReadWriteInt32.cmd");
        }
    }
}
