using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidCtor2_cti_GuidCtor2_cti_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidCtor2_cti_GuidCtor2_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidCtor2_cti\\GuidCtor2_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
