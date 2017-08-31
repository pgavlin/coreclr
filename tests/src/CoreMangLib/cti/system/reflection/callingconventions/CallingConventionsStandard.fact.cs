using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_callingconventions_CallingConventionsStandard_CallingConventionsStandard_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_callingconventions_CallingConventionsStandard_CallingConventionsStandard_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\callingconventions\\CallingConventionsStandard\\CallingConventionsStandard.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
