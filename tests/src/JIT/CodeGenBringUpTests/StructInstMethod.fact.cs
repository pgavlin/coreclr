using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _StructInstMethod_StructInstMethod_
    {
        [OuterLoop]
        [Fact]
        public void _StructInstMethod_StructInstMethod_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\StructInstMethod\\StructInstMethod.cmd");
        }
    }
}
