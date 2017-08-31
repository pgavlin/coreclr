using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _Copy_CopyDoubleArray_CopyDoubleArray_
    {
        [Fact]
        public void _Copy_CopyDoubleArray_CopyDoubleArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Copy\\CopyDoubleArray\\CopyDoubleArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
