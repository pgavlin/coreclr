using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidToByteArray_GuidToByteArray_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidToByteArray_GuidToByteArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidToByteArray\\GuidToByteArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
