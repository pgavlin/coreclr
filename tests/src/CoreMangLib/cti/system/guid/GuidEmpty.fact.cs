using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_guid_GuidEmpty_GuidEmpty_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidEmpty_GuidEmpty_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidEmpty\\GuidEmpty.cmd");
        }
    }
}
