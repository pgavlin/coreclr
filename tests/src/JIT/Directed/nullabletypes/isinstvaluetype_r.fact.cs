using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstvaluetype_r_isinstvaluetype_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstvaluetype_r_isinstvaluetype_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstvaluetype_r\\isinstvaluetype_r.cmd");
        }
    }
}
