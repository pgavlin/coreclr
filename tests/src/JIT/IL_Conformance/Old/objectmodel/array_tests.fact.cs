using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_objectmodel_array_tests_array_tests_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_array_tests_array_tests_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\array_tests\\array_tests.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
