using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributetargets_AttributeTargetsAll_AttributeTargetsAll_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributetargets_AttributeTargetsAll_AttributeTargetsAll_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributetargets\\AttributeTargetsAll\\AttributeTargetsAll.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
