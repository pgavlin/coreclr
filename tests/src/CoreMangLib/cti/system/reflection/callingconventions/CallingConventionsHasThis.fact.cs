using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_callingconventions_CallingConventionsHasThis_CallingConventionsHasThis_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_callingconventions_CallingConventionsHasThis_CallingConventionsHasThis_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\callingconventions\\CallingConventionsHasThis\\CallingConventionsHasThis.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
