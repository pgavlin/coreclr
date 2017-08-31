using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _Copy_CopyInt32Array_CopyInt32Array_
    {
        [Fact]
        public void _Copy_CopyInt32Array_CopyInt32Array_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Copy\\CopyInt32Array\\CopyInt32Array.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
