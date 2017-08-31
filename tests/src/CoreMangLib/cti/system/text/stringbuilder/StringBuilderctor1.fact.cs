using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderctor1_StringBuilderctor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderctor1_StringBuilderctor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderctor1\\StringBuilderctor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
