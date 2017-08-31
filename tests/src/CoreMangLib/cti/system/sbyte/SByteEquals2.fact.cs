using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_sbyte_SByteEquals2_SByteEquals2_
    {
        [OuterLoop]
        [Fact]
        public void _system_sbyte_SByteEquals2_SByteEquals2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\sbyte\\SByteEquals2\\SByteEquals2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
