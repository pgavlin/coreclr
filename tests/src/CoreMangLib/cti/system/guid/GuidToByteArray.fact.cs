using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_guid_GuidToByteArray_GuidToByteArray_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidToByteArray_GuidToByteArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidToByteArray\\GuidToByteArray.cmd");
        }
    }
}
