using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _ReadWrite_ReadWriteByte_ReadWriteByte_
    {
        [Fact]
        public void _ReadWrite_ReadWriteByte_ReadWriteByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\ReadWrite\\ReadWriteByte\\ReadWriteByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
