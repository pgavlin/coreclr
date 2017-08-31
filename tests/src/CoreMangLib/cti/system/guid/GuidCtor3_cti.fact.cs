using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidCtor3_cti_GuidCtor3_cti_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidCtor3_cti_GuidCtor3_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidCtor3_cti\\GuidCtor3_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
