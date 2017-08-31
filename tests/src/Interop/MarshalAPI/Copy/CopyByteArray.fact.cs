using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _Copy_CopyByteArray_CopyByteArray_
    {
        [Fact]
        public void _Copy_CopyByteArray_CopyByteArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Copy\\CopyByteArray\\CopyByteArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
