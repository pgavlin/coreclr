using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _StaticValueField_StaticValueField_
    {
        [OuterLoop]
        [Fact]
        public void _StaticValueField_StaticValueField_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\StaticValueField\\StaticValueField.cmd");
        }
    }
}
