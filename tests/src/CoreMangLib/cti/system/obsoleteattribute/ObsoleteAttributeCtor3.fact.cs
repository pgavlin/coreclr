using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_obsoleteattribute_ObsoleteAttributeCtor3_ObsoleteAttributeCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_obsoleteattribute_ObsoleteAttributeCtor3_ObsoleteAttributeCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\obsoleteattribute\\ObsoleteAttributeCtor3\\ObsoleteAttributeCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
