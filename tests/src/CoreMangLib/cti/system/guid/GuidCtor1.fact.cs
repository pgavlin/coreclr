using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidCtor1_GuidCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidCtor1_GuidCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidCtor1\\GuidCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
