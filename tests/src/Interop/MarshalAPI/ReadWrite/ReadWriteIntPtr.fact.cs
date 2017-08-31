using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _ReadWrite_ReadWriteIntPtr_ReadWriteIntPtr_
    {
        [Fact]
        public void _ReadWrite_ReadWriteIntPtr_ReadWriteIntPtr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\ReadWrite\\ReadWriteIntPtr\\ReadWriteIntPtr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
