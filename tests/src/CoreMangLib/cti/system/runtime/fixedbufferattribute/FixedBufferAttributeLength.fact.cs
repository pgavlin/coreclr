using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_fixedbufferattribute_FixedBufferAttributeLength_FixedBufferAttributeLength_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_fixedbufferattribute_FixedBufferAttributeLength_FixedBufferAttributeLength_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\fixedbufferattribute\\FixedBufferAttributeLength\\FixedBufferAttributeLength.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
