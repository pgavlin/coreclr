using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_obsoleteattribute_ObsoleteAttributeMessage_ObsoleteAttributeMessage_
    {
        [OuterLoop]
        [Fact]
        public void _system_obsoleteattribute_ObsoleteAttributeMessage_ObsoleteAttributeMessage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\obsoleteattribute\\ObsoleteAttributeMessage\\ObsoleteAttributeMessage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
