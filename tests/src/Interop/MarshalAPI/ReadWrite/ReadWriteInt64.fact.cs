using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _ReadWrite_ReadWriteInt64_ReadWriteInt64_
    {
        [Fact]
        public void _ReadWrite_ReadWriteInt64_ReadWriteInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\ReadWrite\\ReadWriteInt64\\ReadWriteInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
