using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _ReadWrite_ReadWriteInt32_ReadWriteInt32_
    {
        [Fact]
        public void _ReadWrite_ReadWriteInt32_ReadWriteInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\ReadWrite\\ReadWriteInt32\\ReadWriteInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
