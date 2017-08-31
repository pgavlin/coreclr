using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_fixedbufferattribute_FixedBufferAttributeElementType_FixedBufferAttributeElementType_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_fixedbufferattribute_FixedBufferAttributeElementType_FixedBufferAttributeElementType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\fixedbufferattribute\\FixedBufferAttributeElementType\\FixedBufferAttributeElementType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
