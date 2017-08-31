using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _Copy_CopyIntPtrArray_CopyIntPtrArray_
    {
        [Fact]
        public void _Copy_CopyIntPtrArray_CopyIntPtrArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Copy\\CopyIntPtrArray\\CopyIntPtrArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
