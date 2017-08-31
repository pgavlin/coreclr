using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_weakreference_WeakReferenceCtor1_PSC_WeakReferenceCtor1_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_weakreference_WeakReferenceCtor1_PSC_WeakReferenceCtor1_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\weakreference\\WeakReferenceCtor1_PSC\\WeakReferenceCtor1_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
