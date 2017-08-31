using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_obsoleteattribute_ObsoleteAttributeCtor2_ObsoleteAttributeCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_obsoleteattribute_ObsoleteAttributeCtor2_ObsoleteAttributeCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\obsoleteattribute\\ObsoleteAttributeCtor2\\ObsoleteAttributeCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
