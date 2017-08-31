using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_weakreference_WeakReferenceIsAliveb_PSC_WeakReferenceIsAliveb_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_weakreference_WeakReferenceIsAliveb_PSC_WeakReferenceIsAliveb_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\weakreference\\WeakReferenceIsAliveb_PSC\\WeakReferenceIsAliveb_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
