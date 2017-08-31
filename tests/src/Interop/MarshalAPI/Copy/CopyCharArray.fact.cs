using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _Copy_CopyCharArray_CopyCharArray_
    {
        [Fact]
        public void _Copy_CopyCharArray_CopyCharArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Copy\\CopyCharArray\\CopyCharArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
