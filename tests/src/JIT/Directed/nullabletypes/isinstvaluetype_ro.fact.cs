using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstvaluetype_ro_isinstvaluetype_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstvaluetype_ro_isinstvaluetype_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstvaluetype_ro\\isinstvaluetype_ro.cmd");
        }
    }
}
