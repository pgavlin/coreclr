using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_fixedbufferattribute_FixedBufferAttributeCtor_FixedBufferAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_fixedbufferattribute_FixedBufferAttributeCtor_FixedBufferAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\fixedbufferattribute\\FixedBufferAttributeCtor\\FixedBufferAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
