using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_weakreference_WeakReferenceTrackResurrection_cti_PSC_WeakReferenceTrackResurrection_cti_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_weakreference_WeakReferenceTrackResurrection_cti_PSC_WeakReferenceTrackResurrection_cti_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\weakreference\\WeakReferenceTrackResurrection_cti_PSC\\WeakReferenceTrackResurrection_cti_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
