using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_weakreference_WeakReferenceTargetb_PSC_WeakReferenceTargetb_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_weakreference_WeakReferenceTargetb_PSC_WeakReferenceTargetb_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\weakreference\\WeakReferenceTargetb_PSC\\WeakReferenceTargetb_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
