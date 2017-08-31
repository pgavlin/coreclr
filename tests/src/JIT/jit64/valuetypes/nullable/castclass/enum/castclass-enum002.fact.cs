using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_enum_castclass_enum002_castclass_enum002_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_enum_castclass_enum002_castclass_enum002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\enum\\castclass-enum002\\castclass-enum002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
