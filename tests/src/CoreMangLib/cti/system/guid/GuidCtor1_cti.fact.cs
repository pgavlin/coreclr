using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidCtor1_cti_GuidCtor1_cti_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidCtor1_cti_GuidCtor1_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidCtor1_cti\\GuidCtor1_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
