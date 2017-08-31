using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_weakreference_WeakReferenceCtor2_PSC_WeakReferenceCtor2_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_weakreference_WeakReferenceCtor2_PSC_WeakReferenceCtor2_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\weakreference\\WeakReferenceCtor2_PSC\\WeakReferenceCtor2_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
