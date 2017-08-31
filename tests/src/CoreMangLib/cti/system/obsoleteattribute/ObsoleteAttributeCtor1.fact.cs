using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_obsoleteattribute_ObsoleteAttributeCtor1_ObsoleteAttributeCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_obsoleteattribute_ObsoleteAttributeCtor1_ObsoleteAttributeCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\obsoleteattribute\\ObsoleteAttributeCtor1\\ObsoleteAttributeCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
