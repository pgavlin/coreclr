using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _OffsetOf_OffsetOf_OffsetOf_
    {
        [Fact]
        public void _OffsetOf_OffsetOf_OffsetOf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\OffsetOf\\OffsetOf\\OffsetOf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
