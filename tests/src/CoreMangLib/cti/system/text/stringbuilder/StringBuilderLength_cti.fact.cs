using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderLength_cti_StringBuilderLength_cti_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderLength_cti_StringBuilderLength_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderLength_cti\\StringBuilderLength_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
