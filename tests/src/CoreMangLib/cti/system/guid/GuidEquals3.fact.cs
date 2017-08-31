using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidEquals3_GuidEquals3_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidEquals3_GuidEquals3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidEquals3\\GuidEquals3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
