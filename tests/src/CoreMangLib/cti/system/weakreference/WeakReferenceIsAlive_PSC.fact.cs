using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_weakreference_WeakReferenceIsAlive_PSC_WeakReferenceIsAlive_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_weakreference_WeakReferenceIsAlive_PSC_WeakReferenceIsAlive_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\weakreference\\WeakReferenceIsAlive_PSC\\WeakReferenceIsAlive_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
