//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\UnitySzakdolgozat1\3DLayoutScriptIDE\3DLayoutScriptIDE\DDD_layout_script.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace _3D_layout_script {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DDD_layout_scriptParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IDDD_layout_scriptListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.signed_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSigned_id([NotNull] DDD_layout_scriptParser.Signed_idContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.signed_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSigned_id([NotNull] DDD_layout_scriptParser.Signed_idContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.vec3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVec3([NotNull] DDD_layout_scriptParser.Vec3Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.vec3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVec3([NotNull] DDD_layout_scriptParser.Vec3Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.type_val"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_val([NotNull] DDD_layout_scriptParser.Type_valContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.type_val"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_val([NotNull] DDD_layout_scriptParser.Type_valContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.binary_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinary_op([NotNull] DDD_layout_scriptParser.Binary_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.binary_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinary_op([NotNull] DDD_layout_scriptParser.Binary_opContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.other_binary_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOther_binary_op([NotNull] DDD_layout_scriptParser.Other_binary_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.other_binary_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOther_binary_op([NotNull] DDD_layout_scriptParser.Other_binary_opContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.xyz"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXyz([NotNull] DDD_layout_scriptParser.XyzContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.xyz"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXyz([NotNull] DDD_layout_scriptParser.XyzContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.modifiable_xyz"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModifiable_xyz([NotNull] DDD_layout_scriptParser.Modifiable_xyzContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.modifiable_xyz"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModifiable_xyz([NotNull] DDD_layout_scriptParser.Modifiable_xyzContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.simple_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_expression([NotNull] DDD_layout_scriptParser.Simple_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.simple_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_expression([NotNull] DDD_layout_scriptParser.Simple_expressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.simple_modifyable_exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_modifyable_exp([NotNull] DDD_layout_scriptParser.Simple_modifyable_expContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.simple_modifyable_exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_modifyable_exp([NotNull] DDD_layout_scriptParser.Simple_modifyable_expContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.operation_helper"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperation_helper([NotNull] DDD_layout_scriptParser.Operation_helperContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.operation_helper"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperation_helper([NotNull] DDD_layout_scriptParser.Operation_helperContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperation([NotNull] DDD_layout_scriptParser.OperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperation([NotNull] DDD_layout_scriptParser.OperationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.variable_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable_decl([NotNull] DDD_layout_scriptParser.Variable_declContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.variable_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable_decl([NotNull] DDD_layout_scriptParser.Variable_declContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.assign_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssign_statement([NotNull] DDD_layout_scriptParser.Assign_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.assign_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssign_statement([NotNull] DDD_layout_scriptParser.Assign_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.attr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttr([NotNull] DDD_layout_scriptParser.AttrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.attr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttr([NotNull] DDD_layout_scriptParser.AttrContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.attr_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttr_group([NotNull] DDD_layout_scriptParser.Attr_groupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.attr_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttr_group([NotNull] DDD_layout_scriptParser.Attr_groupContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.include_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInclude_statement([NotNull] DDD_layout_scriptParser.Include_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.include_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInclude_statement([NotNull] DDD_layout_scriptParser.Include_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.object_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_content([NotNull] DDD_layout_scriptParser.Object_contentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.object_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_content([NotNull] DDD_layout_scriptParser.Object_contentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.object_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_block([NotNull] DDD_layout_scriptParser.Object_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.object_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_block([NotNull] DDD_layout_scriptParser.Object_blockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.if_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_condition([NotNull] DDD_layout_scriptParser.If_conditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.if_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_condition([NotNull] DDD_layout_scriptParser.If_conditionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.if_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_content([NotNull] DDD_layout_scriptParser.If_contentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.if_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_content([NotNull] DDD_layout_scriptParser.If_contentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_statement([NotNull] DDD_layout_scriptParser.If_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_statement([NotNull] DDD_layout_scriptParser.If_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.else_if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElse_if_statement([NotNull] DDD_layout_scriptParser.Else_if_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.else_if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElse_if_statement([NotNull] DDD_layout_scriptParser.Else_if_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.else_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElse_statement([NotNull] DDD_layout_scriptParser.Else_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.else_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElse_statement([NotNull] DDD_layout_scriptParser.Else_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.for_loop_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_loop_statement([NotNull] DDD_layout_scriptParser.For_loop_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.for_loop_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_loop_statement([NotNull] DDD_layout_scriptParser.For_loop_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.range_and_step"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRange_and_step([NotNull] DDD_layout_scriptParser.Range_and_stepContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.range_and_step"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRange_and_step([NotNull] DDD_layout_scriptParser.Range_and_stepContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.for_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_loop([NotNull] DDD_layout_scriptParser.For_loopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.for_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_loop([NotNull] DDD_layout_scriptParser.For_loopContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.program_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram_statement([NotNull] DDD_layout_scriptParser.Program_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.program_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram_statement([NotNull] DDD_layout_scriptParser.Program_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="DDD_layout_scriptParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] DDD_layout_scriptParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DDD_layout_scriptParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] DDD_layout_scriptParser.ProgramContext context);
}
} // namespace _3D_layout_script
