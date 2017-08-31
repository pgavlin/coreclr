using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32CompareTo2_UInt32CompareTo2_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32CompareTo2_UInt32CompareTo2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32CompareTo2\\UInt32CompareTo2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
