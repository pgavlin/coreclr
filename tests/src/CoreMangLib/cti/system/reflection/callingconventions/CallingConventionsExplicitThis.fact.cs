using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_callingconventions_CallingConventionsExplicitThis_CallingConventionsExplicitThis_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_callingconventions_CallingConventionsExplicitThis_CallingConventionsExplicitThis_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\callingconventions\\CallingConventionsExplicitThis\\CallingConventionsExplicitThis.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
