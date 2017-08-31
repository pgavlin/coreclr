using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_sbyte_SByteIConvertibleToDecimal_SByteIConvertibleToDecimal_
    {
        [OuterLoop]
        [Fact]
        public void _system_sbyte_SByteIConvertibleToDecimal_SByteIConvertibleToDecimal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\sbyte\\SByteIConvertibleToDecimal\\SByteIConvertibleToDecimal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
