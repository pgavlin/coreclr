using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_sbyte_SByteCompareTo2_SByteCompareTo2_
    {
        [OuterLoop]
        [Fact]
        public void _system_sbyte_SByteCompareTo2_SByteCompareTo2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\sbyte\\SByteCompareTo2\\SByteCompareTo2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
