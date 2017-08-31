using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderLength_StringBuilderLength_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderLength_StringBuilderLength_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderLength\\StringBuilderLength.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
