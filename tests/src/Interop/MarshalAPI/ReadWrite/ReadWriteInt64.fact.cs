using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _ReadWrite_ReadWriteInt64_ReadWriteInt64_
    {
        [Fact]
        public void _ReadWrite_ReadWriteInt64_ReadWriteInt64_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\ReadWrite\\ReadWriteInt64\\ReadWriteInt64.cmd");
        }
    }
}
