using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _ReadWrite_ReadWriteObject_ReadWriteObject_
    {
        [Fact]
        public void _ReadWrite_ReadWriteObject_ReadWriteObject_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\ReadWrite\\ReadWriteObject\\ReadWriteObject.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
