using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_rethrowincatchnestedinfinally_d_rethrowincatchnestedinfinally_d_
    {
        [Fact]
        public void _eh_nested_general_rethrowincatchnestedinfinally_d_rethrowincatchnestedinfinally_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\rethrowincatchnestedinfinally_d\\rethrowincatchnestedinfinally_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
