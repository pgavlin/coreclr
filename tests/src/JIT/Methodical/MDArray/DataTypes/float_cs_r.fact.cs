using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_DataTypes_float_cs_r_float_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_float_cs_r_float_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\float_cs_r\\float_cs_r.cmd");
        }
    }
}
