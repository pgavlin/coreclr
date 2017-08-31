using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_obsoleteattribute_ObsoleteAttributeIsError_ObsoleteAttributeIsError_
    {
        [OuterLoop]
        [Fact]
        public void _system_obsoleteattribute_ObsoleteAttributeIsError_ObsoleteAttributeIsError_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\obsoleteattribute\\ObsoleteAttributeIsError\\ObsoleteAttributeIsError.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
